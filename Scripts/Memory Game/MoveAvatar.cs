using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class MoveAvatar : MonoBehaviour {

	private GameObject origin, destination;
	private GameDataScript gameData;
	private Button goButton;
	
	// Use this for initialization
	void Start () {

        //Disable the "go" button while the animation is playing
        goButton = GameObject.Find("GoButton").GetComponent<Button>();
        goButton.interactable = false;
        goButton.gameObject.SetActive(false);
	
        gameData = GameObject.Find("GameData").GetComponent<GameDataScript>();	
		
	    int originnum = Math.Max(gameData.Iteration - 1, 0);
	    int destinationnum = Math.Max(gameData.Iteration, 1);
	    string originname = "level" + originnum.ToString();
	    string destinationname = "level" + destinationnum.ToString();
	
	    //Defining the origin and destination of the avatar
	    origin = GameObject.Find(originname);
	    destination = GameObject.Find(destinationname);
	    transform.position = origin.transform.position + new Vector3(0,0,-1);
#if UNITY_ANDROID && !UNITY_EDITOR
	    //Get Opie to look at the animation (by looking at its tummy)
	    Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0f,Opie.Head.transition_action());
#endif
        //Using iTween script functions to move the object from origin to destination (the last argument calls 
        //the function activateGoButton() upon completion of the animation)
        iTween.MoveTo(transform.gameObject, iTween.Hash("position", destination.transform.position + new Vector3(0,0,-1),
            "speed", 1, "delay", 2, "easetype", iTween.EaseType.linear, "oncomplete", "ActivateGoButton"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//This function is called at the end of the animation moving the avatar.
	public void ActivateGoButton(){

        // if quit button is not interactable, that means the quit button has be pressed and is playing
        // the thank you audio, if the go button is activated now the go sound will interrupt the quit sound
        Button quitButton = GameObject.Find("QuitButton").GetComponent<Button>();
        if (!quitButton.IsInteractable())
            return;

#if UNITY_ANDROID && !UNITY_EDITOR
        //Opie looks back up
        Opie.instance().head().set_linked_pose_and_eye_position(0.5f, 0.5f,Opie.Head.transition_action());
#endif
        //Playing the audio instructions "press go"
        ProgressPlaySound pps = GameObject.Find("ProgressPlaySound").GetComponent<ProgressPlaySound>();
        pps.PlayGoLongSound();

#if UNITY_ANDROID && !UNITY_EDITOR
        Opie.instance().head().set_eye_type(EyeType.ATTENTIVE,Opie.Head.instant_action());
#endif
        //Make the "Go!" button interactable
        goButton.gameObject.SetActive(true);
        //goButton.interactable = true;
    }
}
