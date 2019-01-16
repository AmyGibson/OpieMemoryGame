using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class Query_activity : MonoBehaviour {
    private LogInfo logInfo;

    public Text TextStory, TextMemory, TextRepetition, Msg;
    public GameObject ButtonStory, ButtonMemory, ButtonRepetition;
    private int activityChosen = -1;
    private MainLogging mainLog;
    private LoadExternalResources extRes;
    private float startTime;
    
 
	// Use this for initialization
	void Start () {
		//Find the object containing  profile information
		logInfo = GameObject.Find("ProfileInfo").GetComponent<LogInfo>();
        mainLog = GameObject.Find("MainLogging").GetComponent<MainLogging>();

#if UNITY_ANDROID && !UNITY_EDITOR
		//Stop idle motion
		Opie.instance().behaviours ("idle_motion").stop (Opie.Behaviour.instant_action ());
#endif
        extRes = GameObject.Find("LoadExternalResources").GetComponent<LoadExternalResources>();

        //If the resources folder for the selected language does not contain pictures/words subfolder, 
        //then deactivate the Memory Game and Repetition Game
        // if ((Resources.LoadAll(language+"/pictures")).Length == 0){
        if (!extRes.CheckIfPicturesExist()) {
            TextMemory.enabled = false;
            ButtonMemory.SetActive(false);
            TextRepetition.enabled = false;
            ButtonRepetition.SetActive(false);
        }
		//If the resource folder does not contain a Story subfolder, deactivate the story activity
		//if((Resources.LoadAll(language+"/story")).Length == 0){
        if (!extRes.CheckIfStoryExist()) {
            TextStory.enabled = false;
			ButtonStory.SetActive(false);
		}
	}

    

    // Update is called once per frame
    void Update () {
        if (activityChosen == (int)MainLogging.ActivityType.Memory)
        {
            logInfo.LogStartActivity(mainLog.ActivityNames[(int)MainLogging.ActivityType.Memory]);
            mainLog.UpdateLanguageAndActivity();
            UnityEngine.SceneManagement.SceneManager.LoadScene("ProgressMenu");
            /*
             * if (extRes.AreResourcesReady())
            {

                logInfo.LogStartActivity(mainLog.ActivityNames[(int)MainLogging.ActivityType.Memory]);
                mainLog.UpdateLanguageAndActivity();
                Debug.Log("Load memory time" + (Time.realtimeSinceStartup - startTime).ToString());
                UnityEngine.SceneManagement.SceneManager.LoadScene("ProgressMenu");
            }*/

        }
        else if (activityChosen == (int)MainLogging.ActivityType.Repetition)
        {
            if (extRes.AreResourcesReady())
            {
                logInfo.LogStartActivity(mainLog.ActivityNames[(int)MainLogging.ActivityType.Repetition]);
                mainLog.UpdateLanguageAndActivity();
                UnityEngine.SceneManagement.SceneManager.LoadScene("WordRep");
            }

        }else if (activityChosen == (int)MainLogging.ActivityType.Story)
        {
            if (extRes.AreStoryResourcesReady())
            {
                Debug.Log("Load Story time" + (Time.realtimeSinceStartup - startTime).ToString());
                logInfo.LogStartActivity(mainLog.ActivityNames[(int)MainLogging.ActivityType.Story]);
                mainLog.UpdateLanguageAndActivity();
                UnityEngine.SceneManagement.SceneManager.LoadScene("Story_scene");
            }

        }
	}


    
    //If memory game is selected, load the corresponding resources
    // to use coroutine is the loading resources takes up all the computing power and the program is frozen
    // without any status message for a second or two
    // and the text is not updating even when told to update before the loading of resources 
    // this way makes sure at least user knows what is happening
    public void MemorySelected(){
        //startTime = Time.realtimeSinceStartup;
        // StartCoroutine(MemoryLoadResources());
        activityChosen = (int)MainLogging.ActivityType.Memory;
    }
    /*
    private IEnumerator MemoryLoadResources()
    {
        Msg.text = "Loading resources...";
        yield return new WaitForSeconds(0.5f); // to allow for the text to show up
        
        extRes.LoadMemoryGameResources();
        activityChosen = (int)MainLogging.ActivityType.Memory;
    }*/


    //If word repetition game is selected, load the corresponding resources, which is the same as memory game
    public void WordRepetitionSelected()
    {
        StartCoroutine(WordRepLoadResources());
    }

    private IEnumerator WordRepLoadResources() {
        Msg.text = "Loading resources...";
        yield return new WaitForSeconds(0.5f);
        extRes.LoadMemoryGameResources();
        activityChosen = (int)MainLogging.ActivityType.Repetition;
    }

    
	
	//If story is selected, add it to the log info and start storytelling
	public void StorySelected(){
        startTime = Time.realtimeSinceStartup;
        StartCoroutine(StoryLoadResources());
    }

    private IEnumerator StoryLoadResources()
    {
        Msg.text = "Loading resources...";
        yield return new WaitForSeconds(0.1f);
        
        extRes.LoadStoryNextPage(1);
        activityChosen = (int)MainLogging.ActivityType.Story;
    }

    //If quitting at that stage, go back to login screen (to select another profile)
    public void QuitApp(){
		UnityEngine.SceneManagement.SceneManager.LoadScene("profiles_scene");
	}
}
