using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



// this class maybe can combine with loginfo
public class ChangeProfileInfo : MonoBehaviour {

	private LogInfo logInfo;
    

    public Button ButtonNext, ButtonAdd;
	// Use this for initialization
	void Start() {

        if (GameObject.Find("GameData")) {
            Destroy(GameObject.Find("GameData"));
            Debug.Log("Destroy existing GameData");
        }
        if (GameObject.Find("LoadExternalResources"))
        {
            Destroy(GameObject.Find("LoadExternalResources"));
            Debug.Log("Destroy existing LoadExternalResources");
        }

        if (GameObject.Find("MainLogging"))
        {
            Destroy(GameObject.Find("MainLogging"));
            Debug.Log("Destroy existing MainLogging");
        }

        //Load the object containing profile information (it may have been created in another scene)	
        logInfo = GameObject.Find("ProfileInfo").GetComponent<LogInfo>();

        //Define callback functions for buttons
        ButtonNext.onClick.AddListener(ChangeName);
        ButtonAdd.onClick.AddListener(AddName);

        //Start the idle motion. This will cause the eyes to "scan" the environment 
        //while waiting for someone to log in
	    // logInfo already has an Opie reaction 
        //Opie.instance().behaviours ("idle_motion").start (Opie.Behaviour.instant_action ());
        

    }

    // Update is called once per frame
    void Update() {
		
	}
	
	private void ChangeName(){
		logInfo.WriteName();
	}

    //This function is the callback for the Add Profile button. It takes the user to the screen where they can create a new profile.
    private void AddName(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("login_scene");
    }
	
	public void QuitApp(){
		Application.Quit();
	}
}
