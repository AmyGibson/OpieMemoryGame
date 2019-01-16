using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// An object just for sound in this scene

public class LanguagePlaySound : MonoBehaviour
{

    private InstructionSound instrSound;
    private AudioSource soundSource;

    // Use this for initialization
    void Start()
    {
        //get the game object that has all the instruction audio clips
        GameObject isgo = GameObject.Find("InstructionSound");
        instrSound = isgo.GetComponent<InstructionSound>();
        soundSource = GetComponent<AudioSource>();

        //change the audio source to here
        PlayInstructionSound();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void PlayInstructionSound()
    {
        soundSource.PlayOneShot(instrSound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.WhatsLanguage));
        //StartCoroutine(PlayGreetingSound());
    }
    /*
    IEnumerator PlayGreetingSound()
    {
        soundSource.PlayOneShot(instrSound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.WhatsLanguage));
        yield return new WaitWhile(() => soundSource.isPlaying);        
    }*/
}
