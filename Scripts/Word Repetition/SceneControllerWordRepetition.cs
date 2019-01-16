using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using System.Linq;
using UnityEngine.UI;

public class SceneControllerWordRepetition : MonoBehaviour
{
    private const float offsetX = 0.1f;
    private const float offsetY = 0.1f;
    public Text RecordText;
    public Text TranscriptionText;
    private AudioClip recordedaudio;

    private LogInfo logInfo;
    private LoadExternalResources extRes;
    private WordRepPlaySound wrps;
    private int questionNo = 0;
    private string language;
    public Image ImageDisplay;
    public Button NextBtn;
    private Button quitButton;
    private MainLogging mainLog;

    private Star originalStar;
    private Sprite[] images;
    private AudioClip[] sounds;
    private string[] words;
    private string targetText;
    private AudioClip targetSound = null;

    private int[] questions;
    private static System.Random rng = new System.Random();

    private const int totalLevel = 10;
    private List<Star> stars;

    private bool quitPressed = false;

    void Start()
    {
        //Find all the necessary the Game Objects
        logInfo = GameObject.Find("ProfileInfo").GetComponent<LogInfo>();
        originalStar = GameObject.Find("Star").GetComponent<Star>();
        extRes = GameObject.Find("LoadExternalResources").GetComponent<LoadExternalResources>();
        wrps = GameObject.Find("WordRepPlaySound").GetComponent<WordRepPlaySound>();
        quitButton = GameObject.Find("QuitButton").GetComponent<Button>();
        mainLog = GameObject.Find("MainLogging").GetComponent<MainLogging>();

        //Set language name and load resources for it
        language = logInfo.LanguageName;
        images = extRes.MemoryImages;
        sounds = extRes.MemorySounds;
        words = extRes.MemoryWords;

        /*
        questions = Enumerable.Range(0, images.Length).ToArray();
        Shuffle(questions);
        */

        questions = WordsStats.GetOrderingPerformanceBased(mainLog.GetRepetitionSeenWordsStats(), 
            extRes.MemoryWords, totalLevel);

        Vector3 startPosStar = originalStar.transform.position;

        stars = new List<Star>();

        for (int i = 0; i < totalLevel; i++)
        {

            Star star;
            if (i == 0)
                star = originalStar;
            else
                star = Instantiate(originalStar) as Star;

            float posXstar = ((offsetX + star.GetComponent<BoxCollider2D>().bounds.size.y) * i) + startPosStar.x;
            star.transform.position = new Vector3(posXstar, startPosStar.y, startPosStar.z);
            stars.Add(star);
        }

        NextQuestion();

    }

    void Update()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        foreach (Vector2 pos in GetTouchOrMouseInteractions())
        {
            // Get the origin of the tap
            Vector2 origin = Camera.main.ScreenToWorldPoint(pos);
            float Xeye = 0.5f + origin.x / (22.5f - 2f * origin.y);

            Opie.instance().head().set_linked_pose_and_eye_position(Xeye, 0.0f, Opie.Head.transition_action());
        }
#endif
    }


    public void NextQuestion()
    {
        NextBtn.interactable = false;
        ImageDisplay.sprite = extRes.MemoryImages[questions[questionNo]];
        targetSound = extRes.MemorySounds[questions[questionNo]];
        targetText = extRes.MemoryWords[questions[questionNo]];
        TranscriptionText.text = targetText;
        RecordText.text = "";
#if UNITY_ANDROID && !UNITY_EDITOR
        // Opie looks down at the belly
        //Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.0f, Opie.Head.transition_action());
        Opie.instance().head().set_eye_type(EyeType.NEUTRAL,Opie.Head.instant_action());
#endif
        if (!quitPressed)
        {
            StartCoroutine(PlayTargetSound());
        }
    }



    //Shuffling array
    // this is public static should this be in a helper class?
    public static void Shuffle<T>(IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    // need to check if the quit button is pressed any time during these sounds are playing
    IEnumerator PlayTargetSound()
    {
        wrps.PlayCardSound(targetSound);
        yield return new WaitWhile(() => wrps.SoundSource.isPlaying);

        yield return new WaitForSeconds(0.5f); //wait for 0.5s before instruction

        if (!quitPressed)
        {
            //Play the sound asking to repeat ("repeat after me")
            wrps.PlayRecordSound();
            yield return new WaitWhile(() => wrps.SoundSource.isPlaying); // wait for the instruction
            yield return new WaitWhile(() => wrps.SoundSource.isPlaying);//wait for the beep
            //yield return new WaitForSeconds(1); //wait for the beep
            if (!quitPressed)
            {
                StartCoroutine(DisplayRecording());
                StartCoroutine(RecordMic());
            }
        }
    }



    IEnumerable<Vector2> GetTouchOrMouseInteractions()
    {
        if (Input.GetMouseButton(0))
        {
            yield return Input.mousePosition;
        }
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                // Get the origin of the tap
                yield return Input.GetTouch(i).position;
            }
        }
    }

    private IEnumerator TransientEmotion(EyeType emote)
    {
        Opie.instance().head().set_eye_type(emote, Opie.Head.instant_action());
        yield return new WaitForSeconds(2);
        Opie.instance().head().set_eye_type(EyeType.NEUTRAL, Opie.Head.instant_action());
    }


    // this is in a coroutine because updating text UI can cause a delay
    // just make sure that the recording start as soon as after the beep and not
    // waiting for the UI to update
    private IEnumerator DisplayRecording()
    {
        RecordText.text = "recording...";
        yield return null;
    }

    //Record microphone
    public IEnumerator RecordMic()
    {
        //Start recording for 4 seconds
        RecordText.text = "recording...";
        recordedaudio = Microphone.Start(Microphone.devices[0], false, 4, 44100);
        yield return new WaitForSeconds(4);

        if (!quitPressed)
        {
            RecordText.text = "";
            string path = Application.persistentDataPath;
#if UNITY_EDITOR_WIN
            DirectoryInfo dataDir = new DirectoryInfo(Application.persistentDataPath);
            path = dataDir.FullName;
#endif

            //Save the recorded sound
            string filename = path + "/" + logInfo.PlayerName
                + "/" + logInfo.Filename + "_wordRepetition_" + logInfo.LanguageName
                + "_" + questionNo.ToString() + targetText;
            SavWav.Save(filename, recordedaudio);

            if (!quitPressed)
            {
                // if doesnt want to play back, comment this line and use this instead: 
                // FinishOneQuestion();
                LoadAndPlayBack(recordedaudio);
            }
        }

    }



    private void LoadAndPlayBack(AudioClip ac)
    {
        StartCoroutine(LoadOneSound(ac));
#if UNITY_ANDROID && !UNITY_EDITOR
        //Opie is HAPPY to listern to the playback
        StartCoroutine(TransientEmotion(EyeType.ATTENTIVE));
        Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.5f, Opie.Head.transition_action());
#endif
    }


    private IEnumerator LoadOneSound(AudioClip ac)
    {
        
        RecordText.text = "Playing back";
        yield return new WaitForSeconds(1);
        if (!quitPressed)
        {
            wrps.PlayRecordedSound(ac);
            yield return new WaitWhile(() => wrps.SoundSource.isPlaying);
            if (!quitPressed)
            {
                RecordText.text = "next";
                FinishOneQuestion();
            }
        }
    }

    private void FinishOneQuestion()
    {
        stars[questionNo].Setfilled();
        questionNo++;

        // need an out-tro, play the thank you sound maybe?
        if (questionNo >= totalLevel)
        {
            FinishGame();
        }

        List<string> wordsToAdd = new List<string>
        {
            targetText
        };
        mainLog.UpdateRepetitionLog(wordsToAdd);
        NextBtn.interactable = true;
    }


    // if recording is done, change scene progression here
    private void FinishGame()
    {
        if (!quitPressed){
            quitPressed = true;
            quitButton.interactable = false;
            UnityEngine.SceneManagement.SceneManager.LoadScene("profiles_scene");
        }
    }

    public void QuitApp()
    {
       
        // the only way for quitPressed to be true here is when the game has started progressing to
        // next stage, so should not quit. this is an extra safeguard in case the disabling the button 
        // doesnt happen fast enough. Unity doesnt always update the UI immediately
        if (quitPressed)
            return;

        quitPressed = true;
        quitButton.interactable = false;
#if UNITY_ANDROID && !UNITY_EDITOR
        Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.5f, Opie.Head.transition_action());
#endif
        Microphone.End(Microphone.devices[0]);
        if (RecordText.text == "recording...")
            RecordText.text = "Stop recording";
        else if (RecordText.text == "Playing back")
            RecordText.text = "Stop playing back";

        logInfo.Reset();
        extRes.Reset();

        StartCoroutine(QuitAppCo());
    }

    private IEnumerator QuitAppCo()
    {
        wrps.PlayQuitSound();
        yield return new WaitWhile(() => wrps.SoundSource.isPlaying);
        UnityEngine.SceneManagement.SceneManager.LoadScene("profiles_scene");
    }
}
