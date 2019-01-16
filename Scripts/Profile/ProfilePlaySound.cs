using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// An object just for sound in this scene

public class ProfilePlaySound : MonoBehaviour {

    private InstructionSound instrSound;
    private AudioSource soundSource;

    // Use this for initialization
    void Start () {
        //get the game object that has all the instruction audio clips
        instrSound = GameObject.Find("InstructionSound").GetComponent<InstructionSound>();
        soundSource = GetComponent<AudioSource>();

        //change the audio source to here
        PlayInstructionSound();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void PlayInstructionSound()
    {
        StartCoroutine(PlayGreetingSound());
    }

    IEnumerator PlayGreetingSound()
    {
        soundSource.PlayOneShot(instrSound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.Hello));
        yield return new WaitWhile(() => soundSource.isPlaying);

        soundSource.PlayOneShot(instrSound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.WhatsName));
        //yield return new WaitWhile(() => soundSource.isPlaying);

    }
}
