using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;
using System;
using UnityEngine.UI;

public class LogInfo_create : MonoBehaviour {

    private LogInfo logInfo;
    public InputField NewProfileName;
    public Text ErrorMsg;
 
    void Start()
    {
	 logInfo = GameObject.Find("ProfileInfo").GetComponent<LogInfo>();

#if UNITY_ANDROID && !UNITY_EDITOR
	 Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.5f,Opie.Head.transition_action());
	 Opie.instance().head().set_eye_type(EyeType.ATTENTIVE,Opie.Head.instant_action());
#endif

    }






    public void WriteName()
    {
	 //If the user has entered something in the input field, use it as new profile name and create the logging file for it
	    if(NewProfileName.text !=""){
            if (NewProfileName.text.Length > 50)
            {
                ErrorMsg.text = "Profile name too long";
                return;
            }


            if (LogInfo.CheckProfileHasInvalidChars(NewProfileName.text))
            {
                ErrorMsg.text = "Invalid profile name";
                return;
            }

            logInfo.CreatePlayerDir(NewProfileName.text);

                //Go to language selection scene
            UnityEngine.SceneManagement.SceneManager.LoadScene("dynamic_language_selection");
            
	    }
    }
	
}
