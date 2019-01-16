using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class StoryTelling : MonoBehaviour {

	public Image background, mask;
    private Sprite currentImages;
    private Sprite currentMask;
    private AudioClip currentSound;
	private LogInfo logInfo;
	private int totalLevels, level;
    private LoadExternalResources extRes;
    private StoryPlaySound sps;
    private Button quitButton;
    private bool quitPressed = false;
    private bool resourceLoading = false;
    public Text LoadingText;
    private float startTime;

    private void Awake()
    {
        quitButton = GameObject.Find("QuitButton").GetComponent<Button>();
        logInfo = GameObject.Find("ProfileInfo").GetComponent<LogInfo>();
        sps = GameObject.Find("StoryPlaySound").GetComponent<StoryPlaySound>();
        // this code load resources from an external folder at run time 
        extRes = GameObject.Find("LoadExternalResources").GetComponent<LoadExternalResources>();
        //images = extRes.StoryImages;
        //sounds = extRes.StorySounds;
        //masks = extRes.StoryMasks;
        
    }

    // Use this for initialization
    void Start() {
		
		//set level of the story to 1 
		level = 1;

        //The number of levels of the story is the number of images
        totalLevels = extRes.StoryTotalPages;

        SetupNextPage();

    }
	
	// Update is called once per frame
	void Update () {
#if UNITY_ANDROID && !UNITY_EDITOR
		//React to user touches
		foreach (Vector2 pos in GetTouchOrMouseInteractions())
		{
			// Get the origin of the tap
			Vector2 origin = Camera.main.ScreenToWorldPoint(pos);
			float Xeye = 0.5f+origin.x/(22.5f-2f*origin.y);

            // log every tap?? what is the point of logging the position
            /*
			StreamWriter w;
			w = new StreamWriter(Application.persistentDataPath + "/" + logInfo.PlayerName + '/' 
                + logInfo.Filename, true);
			w.WriteLine(DateTime.Now.ToString() + "\t" + origin.x.ToString() + "\t" + origin.y.ToString() + "\n");
			w.Close();
			*/
            //using auto closes streamwrite 
            //prevents problems if w.close() is not executed 
            using (StreamWriter w = logInfo.LogFileInfo.AppendText())
            {
                w.WriteLine(DateTime.Now.ToString() + "\t" + origin.x.ToString() + "\t" + origin.y.ToString());
            }

		    //Get opie to look where the touch occured	
		    Opie.instance().head().set_linked_pose_and_eye_position(Xeye, 0.0f,
		    Opie.Head.transition_action());
		}
#endif

        // if we are waiting for some resources to be loaded
        if (resourceLoading)
        {
            if (extRes.AreStoryResourcesReady())
            {
                resourceLoading = false;
                LoadingText.text = "";
                Debug.Log("Load next page time" + (Time.realtimeSinceStartup - startTime).ToString());
            }
        }

    }

    

    public void TargetFound()
    {

        //If the target is found, log the touch
        Debug.Log("target");

        // using automatically close the stream
        using (StreamWriter w = logInfo.LogFileInfo.AppendText())
        {
            w.Write("target\r\n");
        }

        //Finish the current story sequence (and move to the next)		
        StartCoroutine(FinishedSequence());
	}
	
	//Retrieve user touches
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
	
    private void SetupNextPage()
    {
        //Set the background and mask to the next level (already loaded)
        background.sprite = extRes.StoryNextImage;
        mask.sprite = extRes.StoryNextMask;
        currentSound = extRes.StoryNextSound;
        mask.gameObject.SetActive(true);

#if UNITY_ANDROID && !UNITY_EDITOR
		Opie.instance().head().set_eye_type(EyeType.NEUTRAL,Opie.Head.instant_action());
		Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.5f,Opie.Head.transition_action());
#endif

        // preload the page after in the background and the user is playing with the current
        // page
        if (level + 1 <= totalLevels)
        {
            resourceLoading = true;
            startTime = Time.realtimeSinceStartup;
            extRes.LoadStoryNextPage(level + 1);
        }
    }

    //Called when a story sequence is finished (target found)
    private IEnumerator FinishedSequence(){
#if UNITY_ANDROID && !UNITY_EDITOR
		//Opie looks up
		Opie.instance().head().set_eye_type(EyeType.ATTENTIVE,Opie.Head.instant_action());
		Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.0f,Opie.Head.transition_action());
#endif
        // no more clicking
        mask.gameObject.SetActive(false);

        //Target has been found, so the text of the sequence is read
        sps.PlayStorySound(currentSound);
		
		//Wait for sound to be finished
		yield return new WaitWhile (()=> sps.SoundSource.isPlaying);

        if (quitPressed)
        {
            yield break; // stop the coroutine entirely
        }

		//Move to next level (or quit if last level is reached)
		level++;
		if(level > totalLevels){
            QuitApp();
			yield break;
		}


        // in case the next page is still loading for some reason
        if (resourceLoading)
        {
            LoadingText.text = "loading next page";
        }
        // wait for the loading to finish
        yield return new WaitWhile(() => resourceLoading);
        

        // if not quited not finished, move to next page
        SetupNextPage();
    }



    //If quitting the game at that stge, go back to login screen
    public void QuitApp()
    {

        quitButton.interactable = false;
        quitPressed = true;
#if UNITY_ANDROID && !UNITY_EDITOR
        Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.5f, Opie.Head.transition_action());
#endif
        logInfo.Reset();
        extRes.Reset();

        StartCoroutine(QuitAppCo());
    }


    private IEnumerator QuitAppCo()
    {
        sps.PlayQuitSound();
        yield return new WaitWhile(() => sps.SoundSource.isPlaying);
        UnityEngine.SceneManagement.SceneManager.LoadScene("profiles_scene");
    }

}
