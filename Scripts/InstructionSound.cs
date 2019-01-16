using System.Collections;
using UnityEngine;
using System.IO;


// amy's code to contain all the instruction sound clip and should be accessible for all parts of the game
// these sounds were originally manually linked in the Unity project file
// however there were cases that the linkages of these file were lost during import
// hence the decision of using code to link these sound clips
// which also allow an easier way to change the instruction language if needed (just make sure filenames are the same)
// if new instruction is used one can just change the instruction 

public class InstructionSound : MonoBehaviour {

    //private string instruction_language;
    // probably can put these into an array 
    //private AudioClip ac_hello, ac_name, ac_language, ac_activity, ac_thanks, ac_golong, 
    //   ac_memoryinstr, ac_recallinstr, ac_repeat, ac_cardmatch, ac_tryagain, ac_goshort;
    private AudioClip[] instructionClips = null;
    public enum InstructionAC { Hello, WhatsName, WhatsLanguage, WhatsActivity,
        Thanks, GoLong, MemoryInstruction, RecallInstruction, Repeat,
        CardMatch, TryAgain, GoShort}

    private int total_clip_no = System.Enum.GetNames(typeof(InstructionAC)).Length;

    private float soundST;

    // initialise the audion clip so that other game objects that call these sounds on start will have them
    void Awake()
    {
        instructionClips = new AudioClip[total_clip_no];
        
        //This function ensures that the object is not destructed between scenes 
        //(so that the audio clips are accessible from all scenes)
        DontDestroyOnLoad(transform.gameObject);
    }


    // Use this for initialization
    void Start () {
        LoadSounds();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LoadSounds() {
        // if any sound file name changes, they are all listed here and only need to change the below
        // these file names are as provided
      //  Debug.Log("Load instruction sound");
        soundST = Time.realtimeSinceStartup;
        string path = Application.persistentDataPath + "/ExternalAssets/Instructions";
        Debug.Log(path);
        DirectoryInfo dataDir = new DirectoryInfo(path);
        try
        {
            FileInfo[] fileinfo = dataDir.GetFiles();

            for (int i = 0; i < fileinfo.Length; i++)
            {
                string url = "file:///" + path + "/" + fileinfo[i].Name;

                // this is weird, if I type in a custom folder path for windows
                // it works with file:/// + path as the linus version
                // but not with the persistent data path 
                // the only way to the presistent data path works in windows is 
                // to get the path from the directory again without adding the file:///

#if UNITY_EDITOR_WIN
                url = dataDir.FullName + "/" + fileinfo[i].Name;
#endif

                string fileName = Path.GetFileNameWithoutExtension(fileinfo[i].Name);
                int type = -1;
                switch (fileName)
                {
                    case "Kriol_hello":
                        type = (int)InstructionAC.Hello;
                        break;
                    case "Kriol_Wanim_name":
                        type = (int)InstructionAC.WhatsName;
                        break;
                    case "Kriol_wanim_langus":
                        type = (int)InstructionAC.WhatsLanguage;
                        break;
                    case "Kriol_Start_game":
                        type = (int)InstructionAC.WhatsActivity;
                        break;
                    case "Kriol_Thank_you_bye":
                        type = (int)InstructionAC.Thanks;
                        break;
                    case "Kriol_press_go_long":
                        type = (int)InstructionAC.GoLong;
                        break;
                    case "Kriol_instructions_memory":
                        type = (int)InstructionAC.MemoryInstruction;
                        break;
                    case "Kriol_instructions_recall":
                        type = (int)InstructionAC.RecallInstruction;
                        break;
                    case "Kriol_repeat":
                        type = (int)InstructionAC.Repeat;
                        break;
                    case "Kriol_Gudwan":
                        type = (int)InstructionAC.CardMatch;
                        break;
                    case "Kriol_try_again":
                        type = (int)InstructionAC.TryAgain;
                        break;
                    case "Kriol_press_go":
                        type = (int)InstructionAC.GoShort;
                        break;
                    default:
                        // unused clips
                        break;
                }

                if (type != -1)
                    StartCoroutine(LoadOneSound(url, type));
            }
        }
        catch (System.Exception e)
        {
            Debug.Log("Fail in loading instruction sounds \n");
            Debug.Log(e);
        }

    }


    private IEnumerator LoadOneSound(string url, int i)
    {

        using (WWW www = new WWW(url))
        {
            yield return www;
            instructionClips[i] = www.GetAudioClip(false);
        }
    }

    public bool CheckIfAllSoundsLoaded()
    {
        if (instructionClips == null)
            return false;
        bool alldone = true;
        for (int i = 0; i < instructionClips.Length; i++)
        {
            if (instructionClips[i] == null)
            {
                //Debug.Log("clip " + i.ToString() + "is null");
                alldone = false;
                break;
            }
            AudioDataLoadState res = instructionClips[i].loadState;
            if (res != AudioDataLoadState.Loaded)
            {
                //Debug.Log("clip " + i.ToString() + "is not loaded");
                alldone = false;
                break;
            }
        }
        if (alldone)
            Debug.Log("Load Instruction Sound time" + (Time.realtimeSinceStartup - soundST).ToString());
        return alldone;


    }


    // valid selections are: hello, whatsyourname
    public AudioClip GetInstructionAudioClip(int soundtype) {
        return instructionClips[soundtype];
    }
    
}
