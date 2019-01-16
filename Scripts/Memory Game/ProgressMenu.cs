using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class ProgressMenu : MonoBehaviour {

    public Text TextWritten; //manunally linked in the Unity Editor
    private Button restartBtn;
	private GameDataScript gameData;
	private LogInfo logInfo;
    private LoadExternalResources extRes;
    private Button quitButton;
    private bool quitPressed = false;
    private float startTime;
    private bool resourcesLoaded = true;
    public Button goButton;

    // Use this for initialization
    void Start () {
        //Find the objects containing the game data and the profile information
        gameData = GameObject.Find("GameData").GetComponent<GameDataScript>();
		logInfo = GameObject.Find("ProfileInfo").GetComponent<LogInfo>();
        extRes = GameObject.Find("LoadExternalResources").GetComponent<LoadExternalResources>();
        quitButton = GameObject.Find("QuitButton").GetComponent<Button>();
        //goButton = GameObject.Find("GoButton").GetComponent<Button>();
        restartBtn = GameObject.Find("RestartButton").GetComponent<Button>();

        // move the loading resources to here to hide loading time
        // only load if not loaded
        if (!extRes.IsLoaded())
        {
            resourcesLoaded = false;
            startTime = Time.realtimeSinceStartup;
            extRes.LoadMemoryGameResources();
            restartBtn.interactable = false;
            goButton.interactable = false;
        }
        else {
            goButton.interactable = true;
            restartBtn.interactable = true;
        }



        //Quit the application if the player has reached the last level
        if (gameData.Iteration > gameData.TotalLevel){
            QuitApp();
	    }

        
        if (gameData.Iteration == 1)
            restartBtn.gameObject.SetActive(false);
        else
            restartBtn.gameObject.SetActive(true);

        //Display the name of the user
        TextWritten.text = logInfo.PlayerName;
#if UNITY_ANDROID && !UNITY_EDITOR
	    //Get Opie to look down at its tummy to observe progress
	    Opie.instance().head().set_eye_type(EyeType.NEUTRAL,Opie.Head.instant_action());
	    Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.0f,Opie.Head.transition_action());
#endif 
	}


        


    // Update is called once per frame
    void Update () {
        if (!resourcesLoaded && extRes.AreResourcesReady())
        {
            Debug.Log("Load memory time" + (Time.realtimeSinceStartup - startTime).ToString());
            resourcesLoaded = true;
            goButton.interactable = true;
            restartBtn.interactable = true;
            gameData.GetNewOrdering();
        }

    }
	
	//This functions starts a new level (main scene)
	public void MoveToNext(){
        if (!quitPressed)
        {
            quitPressed = true;
            quitButton.interactable = false;
            UnityEngine.SceneManagement.SceneManager.LoadScene("main-scene");
        }
	}

    // if the restart button is pressed
    public void RestartFromLevel1()
    {
        if (!quitPressed)
        {
            quitPressed = true;
            quitButton.interactable = false;
            gameData.Reset();
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
        //If quitting the application, reset the game info and log info, then reset to profile screen
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
        ProgressPlaySound pps = GameObject.Find("ProgressPlaySound").GetComponent<ProgressPlaySound>();
        pps.PlayQuitSound();
        yield return new WaitWhile(() => pps.SoundSource.isPlaying);
        UnityEngine.SceneManagement.SceneManager.LoadScene("profiles_scene");
    }

}
