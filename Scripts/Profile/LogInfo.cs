using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;
using System;
using UnityEngine.UI;

public class LogInfo : MonoBehaviour {

    private string data;
    //private FileInfo f;
    public FileInfo LogFileInfo { get; private set; }
    private Text input;
    //public InputField input;
    public string Filename { get; private set; }
    public string PlayerName { get; private set; }
    public string LanguageName { get; set; }
    public string ActivityName { get; private set; }
    public static LogInfo instance;
    void Start()
    {
	 
	    //Create the file that logs the information
	    Filename = GetLatestFilename();
#if UNITY_ANDROID && !UNITY_EDITOR
        //When the file is created, set the eyes to look straight up and set their emotion to ATTENTIVE
        Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.5f,Opie.Head.transition_action());
	    Opie.instance().head().set_eye_type(EyeType.ATTENTIVE,Opie.Head.instant_action());
#endif

    }

    public void WriteName()
     {
	    //Find the object containing the name selected by the user
	    input = GameObject.Find("SelectedName_text").GetComponent<Text>();        

        //Check if the user has selected/entered a name
        if (input.text != ""){
     
	        //Prepare the file that will contain the log
	        Filename = GetLatestFilename();
            PlayerName = input.text;

            SetFileInfo();

            //Once the logging is set up, go to language selection scene
            //UnityEngine.SceneManagement.SceneManager.LoadScene("language_selection");

            UnityEngine.SceneManagement.SceneManager.LoadScene("dynamic_language_selection");
        }
     }
    
    
    private void SetFileInfo()
    {
        LogFileInfo = new FileInfo(Application.persistentDataPath + "/" + PlayerName + "/" + Filename);
#if UNITY_EDITOR_WIN
        DirectoryInfo dataDir = new DirectoryInfo(Application.persistentDataPath);
        LogFileInfo = new FileInfo(dataDir.FullName + "/" + PlayerName + "/" + Filename);
#endif
    }

  

    public void Reset(){
        //Resets the logging information        
        Filename = GetLatestFilename();
#if UNITY_ANDROID && !UNITY_EDITOR
        Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.5f,Opie.Head.transition_action());
	    Opie.instance().head().set_eye_type(EyeType.ATTENTIVE,Opie.Head.instant_action());
#endif
    }



    //This function ensures that the object is not destructed between scenes (so that the logging information can be accessed at any time)
    void Awake() {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
        //DontDestroyOnLoad(transform.gameObject);
    }

    // below are a series of get/set methods to access to the originally public varibales

    private string GetLatestFilename()
    {
        return DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + "_"
            + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_"
            + DateTime.Now.Minute.ToString() + "_00_log";
    }


    public void LogStartActivity(string activity)
    {
        ActivityName = activity;
        StreamWriter w = LogFileInfo.CreateText();
        w.WriteLine("Name : " + PlayerName);
        w.WriteLine("Language : " + LanguageName);
        w.WriteLine("Activity : " + ActivityName);
        w.Close();
    }

    public void CreatePlayerDir(string playerName)
    {
        Filename = GetLatestFilename();
        PlayerName = playerName;
        SetFileInfo();
        //Create the directory for that user
        if (!Directory.Exists(Application.persistentDataPath + "/" + PlayerName))
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            Directory.CreateDirectory(Application.persistentDataPath + "/" + PlayerName);
#endif
#if UNITY_EDITOR_WIN
            DirectoryInfo dataDir = new DirectoryInfo(Application.persistentDataPath);
            Directory.CreateDirectory(dataDir.FullName + "/" + PlayerName);
#endif
        }
    }


    public static bool CheckProfileHasInvalidChars(string profileName)
    {
        return profileName.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) >= 0;
    }
}
