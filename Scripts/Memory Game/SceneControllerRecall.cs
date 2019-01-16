using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using System.Linq;
using UnityEngine.UI;

public class SceneControllerRecall : MonoBehaviour
{
    private int noOfCard;
	private const float offsetX = 0.1f;
    private const float offsetY = 0.1f;


    //public Transform mcbn;
	public Text TranscriptionText;

	private GameDataScript gameData;
	private LogInfo logInfo;
    private LoadExternalResources extRes;
    private MainLogging mainLog;
    private Button quitButton;
    private int questionNo = 0;
	private int correctScore = 0;
	
    private RecallPlaySound rps;
	private MemoryCardRecall originalCard;
	private Star originalStar;
	private Sprite[] images;
	private AudioClip[] sounds;
	private string[] words;
    
	private AudioClip targetSound = null;
	private string targetTranscription;

	private List<string> correct, incorrect, oneShotCorrect;
    private int[] questions;
    private int[] answers;
	private int[] ordering;
    private List<Star> stars;
    private List<MemoryCardRecall> cards;

    private bool isplaying = false;
    private bool quitPressed = false;
    private int attempts = 0;

    private static System.Random rng = new System.Random();

	void Start ()
	{
        //Find all the necessary the Game Objects
        gameData = GameObject.Find("GameData").GetComponent<GameDataScript>();
		logInfo= GameObject.Find("ProfileInfo").GetComponent<LogInfo>();
        originalCard = GameObject.Find("Memory Card").GetComponent<MemoryCardRecall>();
        originalStar = GameObject.Find("Star").GetComponent<Star>();
        extRes = GameObject.Find("LoadExternalResources").GetComponent<LoadExternalResources>();
        rps = GameObject.Find("RecallPlaySound").GetComponent<RecallPlaySound>();
        quitButton = GameObject.Find("QuitButton").GetComponent<Button>();
        mainLog = GameObject.Find("MainLogging").GetComponent<MainLogging>();


#if UNITY_ANDROID && !UNITY_EDITOR
		//Opie looks up with NEUTRAL emotion
		Opie.instance().head().set_eye_type(EyeType.NEUTRAL,Opie.Head.instant_action());
		Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.5f,Opie.Head.transition_action());
#endif

        //Retrieve ordering of the images, all the resources should have already been loaded
        ordering = gameData.Ordering;

        images = extRes.MemoryImages;
        sounds = extRes.MemorySounds;
        words = extRes.MemoryWords;
        noOfCard = gameData.NRows * gameData.NCols / 2;

        //Shuffle the order of the cards to be Question
        questions = Enumerable.Range(0, noOfCard).ToArray();
        
        Shuffle(questions);

        answers = new int[noOfCard];
        for (int i = 0; i < noOfCard; i++)
        {
            answers[i] = ordering[questions[i]];
        }

        CardsSetup();

        //Initializing the vectors of correct and incorrect answers
        correct = new List<string>();
        incorrect = new List<string>();
        oneShotCorrect = new List<string>();
        //mcbn.GetComponent<Button>().interactable = false;

        DeactivateAllCards();
        //Present the first word (sound + transcription) 
        NextQuestion();
    }


    private void CardsSetup() {

        // positioning
        Vector3 startPos = originalCard.transform.position;
        Vector3 startPosStar = originalStar.transform.position;
        stars = new List<Star>();
        cards = new List<MemoryCardRecall>();
        
        //randomly laying out the card
        int[] cardLayoutOrder = Enumerable.Range(0, noOfCard).ToArray();
        Shuffle(cardLayoutOrder);

        // Populating the grid by instantiating the Cards and the Stars (changing color to reflect player performance)
        for (int i = 0; i < noOfCard; i++)
        {
            MemoryCardRecall card;
            Star star;
            if (i == 0)
            {
                card = originalCard;
                star = originalStar;
            }
            else
            {
                card = Instantiate(originalCard) as MemoryCardRecall;
                star = Instantiate(originalStar) as Star;
            }
            stars.Add(star);
            cards.Add(card);
            int id = answers[cardLayoutOrder[i]];
            card.SetCard(id, images[id]);

            int j = (int)Math.Truncate(i / 5f);
            float posX = ((offsetX + card.GetComponent<BoxCollider2D>().bounds.size.x) * (i - j * 5)) + startPos.x;
            float posY = -((offsetY + card.GetComponent<BoxCollider2D>().bounds.size.y) * j) + startPos.y;
            card.transform.position = new Vector3(posX, posY, startPos.z);
            float posXstar = ((offsetX + star.GetComponent<BoxCollider2D>().bounds.size.y) * i) + startPosStar.x;
            star.transform.position = new Vector3(posXstar, startPosStar.y, startPosStar.z);
        }
    }


    private bool CheckIfDone()
    {

        //If all the cards have been presented
        if (questionNo == noOfCard - 1)
        {
            //Log the  performance
            
            //using auto closes streamwrite 
            //prevents problems if w.close() is not executed 
            using (StreamWriter w = logInfo.LogFileInfo.AppendText())
            {
                w.WriteLine("level " + noOfCard.ToString() + " : scored " + correctScore.ToString());
                w.WriteLine("correct : " + string.Join(",", correct.ToArray()));
                w.WriteLine("incorrect : " + string.Join(",", incorrect.ToArray()));
                w.WriteLine();
            }

            correct.AddRange(incorrect);
            mainLog.UpdateMemoryLog(noOfCard, correct);

            if (noOfCard > 1 && oneShotCorrect.Count != 0)
                mainLog.UpdateRecallLog(oneShotCorrect);

            //Trigger the level to increase
            gameData.LevelPassed();
            //Goes back to Progress Menu
            GoToNext();
            return true;
        }
        return false;
    }

    void Update() {
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


    //Shuffling array
    // this is public static should this be in a helper class?
    public static void Shuffle<T>(IList<T> list)  
	{  
		int n = list.Count;  
		while (n > 1) {  
			n--;
			int k = rng.Next(n + 1);  
			T value = list[k];
			list[k] = list[n];
			list[n] = value;
		}  
	}


	//Check for matches between the card selected and the target sound
	public void StartCheckMatch(int idClicked)
	{
        // deactive all card for these actions to happen (otherwise user can just click through the cards)
        DeactivateAllCards();
        StartCoroutine (CheckMatch(idClicked));
	}

    public void DeactivateAllCards() {
        for (int i = 0; i < noOfCard; i++)
            cards[i].Deactive();
    }

    private void ActivateAllCards()
    {
        for (int i = 0; i < noOfCard; i++)
            cards[i].Activate();
    }

    private IEnumerator CheckMatch(int idClicked) {


        /*
        // below is to control the game flow
        // if at soon as the game is loaded, someone press an image
        // it will 1. cut off the instruction 2. still play the current word 
        // before going to the next word
        //
        // I have changed my mind later, all cards are deactivated initially
        // so the below code doesnt do anything
        if (questionNo == 0)
        {
            rps.SoundSource.Stop(); //to cut off the instruction

            yield return new WaitWhile(() => rps.SoundSource.isPlaying);
            // for some reason it doesnt stop immediately

            yield return new WaitWhile(() => rps.SoundSource.isPlaying);
            // this is to make sure the target word is played in full
        }
        */

        attempts++;

        //If there is a match 
        if (idClicked == answers[questionNo]) {
#if UNITY_ANDROID && !UNITY_EDITOR
            //Opie is HAPPY if the guess is right
            StartCoroutine(TransientEmotion(EyeType.ATTENTIVE));
			Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.5f,Opie.Head.transition_action());
#endif
			correctScore++;

            stars[questionNo].Setfilled();

            rps.PlayCardMatchSound();
            yield return new WaitWhile(() => rps.SoundSource.isPlaying);
            

            //Add the trasncripton of the word to the list of correctly recognized words (for teacher feedback)
            correct.Add(targetTranscription);

            if (noOfCard > 1 && attempts == 1)
                oneShotCorrect.Add(targetTranscription);

            attempts = 0;
            //if trying mode
            if (!CheckIfDone())
            {
                //Increment the question number
                questionNo++;
                NextQuestion();
            }

        }
		else {
#if UNITY_ANDROID && !UNITY_EDITOR
			//Opie is SAD if the guess is wrong
			StartCoroutine(TransientEmotion(EyeType.SAD));
			Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.5f,Opie.Head.transition_action());
#endif
            rps.PlayCardMismatchSound();
            yield return new WaitWhile(() => rps.SoundSource.isPlaying);
            //Add the transcirption of the word to the list of incorrectly recognized words (for teacher feedback)
            incorrect.Add(targetTranscription);

            // if trying mode
            StartCoroutine(BlockPlayWord(questionNo));
        }


        // if testing mode
       /* if (!CheckIfDone())
        {
            //Increment the question number
            questionNo++;
            NextQuestion();
        }*/
    }


    // block all card clicking when playing a word
    private IEnumerator BlockPlayWord(int current_question_no) {

        // in case some other sound is playing, eg intro
        yield return new WaitWhile(() => rps.SoundSource.isPlaying);

        PlayTargetSound();
        targetTranscription = words[ordering[questions[questionNo]]];
        TranscriptionText.text = targetTranscription;
        yield return new WaitWhile(() => rps.SoundSource.isPlaying);

        // the first question by default all cards are activated, and all card are deactivated on clicked
        // but this coroutine is still running (first run at start) so it will activate the card
        // once the first word has been played even the answer has already been clicked
        // and easy way to solve is to not to reactivate the card here at first question
        //if (current_question_no > 0)
            ActivateAllCards();
    }


    private void NextQuestion()
    {
        targetSound = sounds[ordering[questions[questionNo]]];

        // the problem is there are multiple block play word running
        // another one is launch before finish check match
        StartCoroutine(BlockPlayWord(questionNo));
        
        
        
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
	
	private IEnumerator TransientEmotion(EyeType emote){
#if UNITY_ANDROID && !UNITY_EDITOR
		Opie.instance().head().set_eye_type(emote,Opie.Head.instant_action());
#endif
		yield return new WaitForSeconds(2); //2
#if UNITY_ANDROID && !UNITY_EDITOR
		Opie.instance().head().set_eye_type(EyeType.NEUTRAL,Opie.Head.instant_action());
#endif
	}

	// go to next scene
    private void GoToNext()
    {
        // if the quit button is pressed and is currently playing the quit sound
        // should not progress
        if (!quitPressed)
        {
            quitPressed = true;
            // as soon as the progression has started, can not quit
            quitButton.interactable = false;
            StartCoroutine(GoToNextCo());
        }
    }

    // if the extra word repetition section is not needed, change scene progression here
    private IEnumerator GoToNextCo()
    {
        // need to play the last card match/mismatch sound
        yield return new WaitWhile(() => rps.SoundSource.isPlaying);
        //UnityEngine.SceneManagement.SceneManager.LoadScene("ProgressMenu");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Memory_Repeat");
    }



    public void PlayTargetSound(){
        rps.PlayCardSound(targetSound);
        
    }
	
	public void QuitApp(){

        // the only way for quitPressed to be true here is when the game has started progressing to
        // next stage, so should not quit. this is an extra safeguard in case the disabling the button 
        // doesnt happen fast enough. Unity doesnt always update the UI immediately
        if (quitPressed)
            return;
        DeactivateAllCards();
        quitPressed = true;
#if UNITY_ANDROID && !UNITY_EDITOR
        Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.5f, Opie.Head.transition_action());
#endif
        gameData.Reset();
        logInfo.Reset();
        extRes.Reset();
        
        quitButton.interactable = false;

        StartCoroutine(QuitAppCo());
    }


    private IEnumerator QuitAppCo()
    {
        rps.PlayQuitSound();
        yield return new WaitWhile(() => rps.SoundSource.isPlaying);
        UnityEngine.SceneManagement.SceneManager.LoadScene("profiles_scene");
    }



}
