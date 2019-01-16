using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Query_language : MonoBehaviour {
	
	private LogInfo logInfo;
    public Text UsernameText;
	
	// Use this for initialization
	void Start () {
        //When entering this scene, stop the idle motion so that Opie stops scanning the environment with its eyes
#if UNITY_ANDROID && !UNITY_EDITOR
        Opie.instance().behaviours ("idle_motion").stop (Opie.Behaviour.instant_action ());
#endif
        //Find the object containing profile information
        logInfo = GameObject.Find("ProfileInfo").GetComponent<LogInfo>();

        //Write the username on screen (for verification purpose)
        UsernameText.text = logInfo.PlayerName;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//This function is called when a language button is pressed
	public void Language_selected(string language){
        //In logging information, set the language
        logInfo.LanguageName = language;
		//Go to the activity selection scene
		UnityEngine.SceneManagement.SceneManager.LoadScene("activity_selection");
	}
	
	public void QuitApp(){
		//if quitting at that stage, go back to login screen (to select new profile)
		UnityEngine.SceneManagement.SceneManager.LoadScene("profiles_scene");
    }

    //only on dynamic language scene, This function is called when the go button is pressed
    public void DynamicLanguageSelected()
    {

        Text languageText = GameObject.Find("SelectedLanguage_text").GetComponent<Text>();
        if (languageText.text == "")
        {
            Debug.Log("no language selected yet");
            return;
        }

        //In logging information, set the language
        logInfo.LanguageName = languageText.text;

        //Go to the activity selection scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("activity_selection");
    }

}
