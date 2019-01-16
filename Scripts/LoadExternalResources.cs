using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class LoadExternalResources : MonoBehaviour {


    public Text Msg;
    private string language;

   
    public Sprite[] MemoryImages { get; private set; }
    public AudioClip[] MemorySounds { get; private set; }
    public string[] MemoryWords { get; private set; }

    public Sprite StoryNextImage { get; private set; }
    public Sprite StoryNextMask { get; private set; }
    public AudioClip StoryNextSound { get; private set; }
    public int StoryTotalPages { get; private set; }
    //public Sprite[] StoryImages { get; private set; }
    //public AudioClip[] StorySounds { get; private set; }
    //public Sprite[] StoryMasks { get; private set; }


    //these are just for timing for debugging
    //private float soundST;

    // making thing a singleton instead of DontDestroyOnLoad,
    // otherwise duplicates will be created everytime this scene is load
    public static LoadExternalResources Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
        
    }


    // check if a subfolder exist, may need to futher check if it is empty
    public bool CheckIfPicturesExist() {
        language = GetCurrentLanguage();
        string path = Application.persistentDataPath + "/ExternalAssets/" + language + "/pictures";
#if UNITY_EDITOR_WIN
        DirectoryInfo dataDir = new DirectoryInfo(path);
        path = dataDir.FullName;
#endif
        if (Directory.Exists(path))
            return true;

        //Debug.Log(path + " doesnt exists");
        return false;
    }

    public bool CheckIfStoryExist()
    {
        language = GetCurrentLanguage();
        string path = Application.persistentDataPath + "/ExternalAssets/" + language + "/story/pictures";
#if UNITY_EDITOR_WIN
        DirectoryInfo dataDir = new DirectoryInfo(path);
        path = dataDir.FullName;
#endif

        if (Directory.Exists(path))
            return true;

       // Debug.Log(path + " doesnt exists");
        return false;
    }



    private void LoadMemoryImages()
    {
        string path = Application.persistentDataPath + "/ExternalAssets/" + language + "/pictures";

        DirectoryInfo dataDir = new DirectoryInfo(path);
        try
        {
            FileInfo[] fileinfo = dataDir.GetFiles();
            MemoryImages = new Sprite[fileinfo.Length];

            for (int i = 0; i < fileinfo.Length; i++)
            {
                string url = "file:///" + path + "/" + fileinfo[i].Name;

#if UNITY_EDITOR_WIN
                url = dataDir.FullName + "/" + fileinfo[i].Name;
#endif

                StartCoroutine(LoadMemoryOneImage(url, i));
            }
        }
        catch (System.Exception e)
        {
            Debug.Log("Fail in loading memory game pictures \n");
            Debug.Log(e);
        }
    }

    private IEnumerator LoadMemoryOneImage(string url, int i)
    {
        Texture2D tex = new Texture2D(4, 4);
        using (WWW www = new WWW(url))
        {
            yield return www;
            www.LoadImageIntoTexture(tex);
            MemoryImages[i] = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height),
                        new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect);
        }

    }

    private bool CheckAllMemoryImages()
    {
        if (MemoryImages == null)
            return false;
        for (int i = 0; i < MemoryImages.Length; i++)
        {
            if (MemoryImages[i] == null)
                return false;
        }
        return true;
    }

    private void LoadMemorySounds()
    {
        //soundST = Time.realtimeSinceStartup;
        string path = Application.persistentDataPath + "/ExternalAssets/" + language + "/sounds";

        DirectoryInfo dataDir = new DirectoryInfo(path);
        try
        {
            FileInfo[] fileinfo = dataDir.GetFiles();
            MemorySounds = new AudioClip[fileinfo.Length];

            for (int i = 0; i < fileinfo.Length; i++)
            {
                string url = "file:///" + path + "/" + fileinfo[i].Name;
#if UNITY_EDITOR_WIN
                url = dataDir.FullName + "/" + fileinfo[i].Name;
#endif
                StartCoroutine(LoadOneSound(url, i));
            }
        }
        catch (System.Exception e)
        {
            Debug.Log("Fail in loading memory game sounds \n");
            Debug.Log(e);
        }
    }

    private IEnumerator LoadOneSound(string url, int i)
    {
        using (WWW www = new WWW(url))
        {
            yield return www;
            MemorySounds[i] = www.GetAudioClip();
        }

    }


    private void LoadMemoryWords()
    {
        //float startTime = Time.realtimeSinceStartup;
        string path = Application.persistentDataPath + "/ExternalAssets/" + language + "/words";

        DirectoryInfo dataDir = new DirectoryInfo(path);
        try
        {
            FileInfo[] fileinfo = dataDir.GetFiles();
            MemoryWords = new string[fileinfo.Length];

            for (int i = 0; i < fileinfo.Length; i++)
            {
                string url = "file:///" + path + "/" + fileinfo[i].Name;
#if UNITY_EDITOR_WIN
                url = dataDir.FullName + "/" + fileinfo[i].Name;
#endif
                StartCoroutine(LoadOneWord(url, i));
            }
        }
        catch (System.Exception e)
        {
            Debug.Log("Fail in loading memory game words \n");
            Debug.Log(e);
        }
       // Debug.Log("LoadMemoryWords time" + (Time.realtimeSinceStartup - startTime).ToString());

    }

    private IEnumerator LoadOneWord(string url, int i)
    {
        using (WWW www = new WWW(url))
        {
            yield return www;
            MemoryWords[i] = www.text;
        }

    }

    public bool IsLoaded() {
        if (MemoryImages == null)
            return false;
        return true;
    }


    public void Reset()
    {
        MemoryImages = null;
        MemorySounds = null;
        MemoryWords = null;
        StoryNextImage = null;
        StoryNextSound = null;
        StoryNextMask = null;
    }

    private string GetCurrentLanguage() {
        return GameObject.Find("ProfileInfo").GetComponent<LogInfo>().LanguageName;
    }
    
    public void LoadMemoryGameResources() {
        
        language = GetCurrentLanguage();
        LoadMemoryImages();
        LoadMemorySounds();
        LoadMemoryWords();
    }



    public bool AreResourcesReady()
    {
        if (!CheckAllMemoryImages())
            return false;
        else
            return CheckIfAllSoundsLoaded();
    }

    private bool CheckIfAllSoundsLoaded()
    {
        if (MemorySounds == null)
            return false;
        bool alldone = true;
        for (int i = 0; i < MemorySounds.Length; i++)
        {
            if (MemorySounds[i] == null)
            {
                alldone = false;
                break;
            }
            AudioDataLoadState res = MemorySounds[i].loadState;
            if (res != AudioDataLoadState.Loaded)
            {
                alldone = false;
                Msg.text = "waiting to load sound " + i.ToString();
                break;
            }
        }
        //if (alldone)
         //   Debug.Log("LoadMemorySound time" + (Time.realtimeSinceStartup - soundST).ToString());
        return alldone;

    }

    /**********************************
     *  story related function here
     * 
     * ******************************/

   

    public void LoadStoryNextPage(int pageNo)
    {
        language = GetCurrentLanguage();
        StoryNextImage = null;
        StoryNextMask = null;
        StoryNextSound = null;

        LoadStoryNextElement(pageNo, "pictures");
        LoadStoryNextElement(pageNo, "masks");
        LoadStoryNextElement(pageNo, "sounds");
    }


    // type can be: pictures, masks and sounds
    private void LoadStoryNextElement(int pageNo, string type)
    {
        //string path = Application.persistentDataPath + "/ExternalAssets/" + language + "/story/pictures";
        string path = Application.persistentDataPath + "/ExternalAssets/" + language + "/story/" + type;

        DirectoryInfo dataDir = new DirectoryInfo(path);
        FileInfo[] fileinfo = dataDir.GetFiles();
        if (pageNo == 1 && type == "pictures")
            StoryTotalPages = fileinfo.Length;


        string url = "file:///" + path + "/" + fileinfo[pageNo - 1].Name;
#if UNITY_EDITOR_WIN
        url = dataDir.FullName + "/" + fileinfo[pageNo - 1].Name;
#endif
        if (type == "pictures")
            StartCoroutine(LoadOneStoryImage(url));
        if (type == "masks")
            StartCoroutine(LoadOneStoryMask(url));
        if (type == "sounds")
            StartCoroutine(LoadOneStorySound(url));
    }



    private IEnumerator LoadOneStoryImage(string url)
    {
        Texture2D tex = new Texture2D(4, 4);
        using (WWW www = new WWW(url))
        {
            yield return www;
            www.LoadImageIntoTexture(tex);
            StoryNextImage = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height),
                        new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect);
        }

    }

    private IEnumerator LoadOneStoryMask(string url)
    {
        Texture2D tex = new Texture2D(4, 4);
        using (WWW www = new WWW(url))
        {
            yield return www;
            www.LoadImageIntoTexture(tex);
            StoryNextMask = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height),
                        new Vector2(0.5f, 0.5f), 100, 0, SpriteMeshType.FullRect);
        }

    }

    
    private IEnumerator LoadOneStorySound(string url)
    {
        using (WWW www = new WWW(url))
        {
            yield return www;
            StoryNextSound = www.GetAudioClip();
        }

    }
    
    public bool AreStoryResourcesReady()
    {
        if (StoryNextImage == null)
            return false;
        else if (StoryNextMask == null)
            return false;
        else if (StoryNextSound == null)
            return false;
        else
        {
            AudioDataLoadState res = StoryNextSound.loadState;
            return res == AudioDataLoadState.Loaded;
        }
    }





    // Use this for initialization
    void Start () {
        Reset();
    }
	
	// Update is called once per frame
	void Update () {
      
    }

  




}


