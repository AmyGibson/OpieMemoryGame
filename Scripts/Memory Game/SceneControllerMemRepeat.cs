using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SceneControllerMemRepeat : MonoBehaviour {

    public Text TranscriptionText;
    public Text RecordingText;
    public Image MemoryCard;
    private AudioClip recordedaudio;

    private GameDataScript gameData;
    private LogInfo logInfo;
    private LoadExternalResources extRes;
    private Button quitButton;

    private int questionNo;
    private bool recordingDone = false;
    private bool quitPressed = false;

    private MemRepeatPlaySound mrps;

    private AudioClip targetSound = null;
    private int[] ordering;
    private string targetText;

    void Start()
    {
        //Find all the necessary the Game Objects
        gameData = GameObject.Find("GameData").GetComponent<GameDataScript>();
        logInfo = GameObject.Find("ProfileInfo").GetComponent<LogInfo>();
        extRes = GameObject.Find("LoadExternalResources").GetComponent<LoadExternalResources>();
        mrps = GameObject.Find("MemRepeatPlaySound").GetComponent<MemRepeatPlaySound>();
        quitButton = GameObject.Find("QuitButton").GetComponent<Button>();

        //Retrieve ordering of the images, all the resources should have already been loaded
        //ordering = gameData.Ordering;
        // the iteration has increased at the end of the recalled scene, so -1 to bring it back to the actual level
        //questionNo = gameData.Iteration - 1;

        // an ID randomly chosen from the last seen set of questions
        int chosen = gameData.MemRepeatID; // start counting from 0
        MemoryCard.sprite = extRes.MemoryImages[chosen];
        targetSound = extRes.MemorySounds[chosen];
        targetText = extRes.MemoryWords[chosen];

        TranscriptionText.text = targetText;
        RecordingText.text = "";

        StartCoroutine(PlayTargetSound());
#if UNITY_ANDROID && !UNITY_EDITOR
        // Opie looks down at the belly
        Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.0f, Opie.Head.transition_action());
#endif
    }


   

    void Update()
    {
        // scene transition here so that if the app is quitted half way through recording the
        // mic is stopped and audio is discarded to prevent errors/junk data
        // "recordingDone" should only be true after recording and it is safe to SavWav
        if (recordingDone)
            GoToNext();

#if UNITY_ANDROID && !UNITY_EDITOR
        //React to user touches
        foreach (Vector2 pos in GetTouchOrMouseInteractions())
        {

            // Get the origin of the tap
            Vector2 origin = Camera.main.ScreenToWorldPoint(pos);
            float Xeye = 0.5f + origin.x / (22.5f - 2f * origin.y);

            //Get Opie to look where the touch happened
            Opie.instance().head().set_linked_pose_and_eye_position(Xeye, 0.0f, Opie.Head.transition_action());
        }
#endif
    }



    //Collect user touches for Opie to trace
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
#if UNITY_ANDROID && !UNITY_EDITOR
        Opie.instance().head().set_eye_type(emote, Opie.Head.instant_action());
#endif
        yield return new WaitForSeconds(2);
#if UNITY_ANDROID && !UNITY_EDITOR
        Opie.instance().head().set_eye_type(EyeType.NEUTRAL, Opie.Head.instant_action());
#endif
    }
    

    // need to check if the quit button is pressed any time during these sounds are playing
    IEnumerator PlayTargetSound()
    {
        mrps.PlayCardSound(targetSound);
        yield return new WaitWhile(() => mrps.SoundSource.isPlaying);

        yield return new WaitForSeconds(0.5f);

        if (!quitPressed) { 

            //Play the sound asking to repeat ("repeat after me")
            mrps.PlayRecordSound();
            yield return new WaitWhile(() => mrps.SoundSource.isPlaying); // wait for the instruction
            //yield return new WaitForSeconds(0.5f); //wait for the beep
            yield return new WaitWhile(() => mrps.SoundSource.isPlaying);
            //yield return new WaitForSeconds(0.5f); //wait for the beep
            if (!quitPressed)
            {
                StartCoroutine(DisplayRecording());
                StartCoroutine(RecordMic());
            }
        }
    }

    // this is in a coroutine because updating text UI can cause a delay
    // just make sure that the recording start as soon as after the beep and not
    // waiting for the UI to update
    private IEnumerator DisplayRecording()
    {
        RecordingText.text = "recording...";
        yield return null;
    }

        //Record microphone
    private IEnumerator RecordMic()
    {

        //Start recording for 4 seconds
        recordedaudio = Microphone.Start(Microphone.devices[0], false, 4, 44100);
        yield return new WaitForSeconds(4);


        // if the quit button is pressed during recording, it should not trigger the SavWav and move to next
        if (!quitPressed)
        {
            RecordingText.text = "Done";
            recordingDone = true;
        }

    }

    
    // if recording is done, change scene progression here
    private void GoToNext()
    {
        // if quite button is pressed, doesnt save
        if (!quitPressed)
        {
            quitPressed = true;
            quitButton.interactable = false;
            string path = Application.persistentDataPath;

#if UNITY_EDITOR_WIN
            DirectoryInfo dataDir = new DirectoryInfo(Application.persistentDataPath);
            path = dataDir.FullName;
#endif

            //Save the recorded sound
            SavWav.Save(path + "/" + logInfo.PlayerName
                + "/" + logInfo.Filename + "_memoryRepetition_" + logInfo.LanguageName
                + "_" + questionNo.ToString() + targetText, recordedaudio);

            UnityEngine.SceneManagement.SceneManager.LoadScene("ProgressMenu");
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
        if (RecordingText.text == "recording...")
            RecordingText.text = "Stop recording";
        gameData.Reset();
        logInfo.Reset();
        extRes.Reset();

        
        StartCoroutine(QuitAppCo());

    }

    private IEnumerator QuitAppCo()
    {
        mrps.PlayQuitSound();
        yield return new WaitWhile(() => mrps.SoundSource.isPlaying);
        UnityEngine.SceneManagement.SceneManager.LoadScene("profiles_scene");
    }
}
