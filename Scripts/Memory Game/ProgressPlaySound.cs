using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressPlaySound : MonoBehaviour {

    private InstructionSound instrSound;
    public AudioSource SoundSource { get; private set; }


    // Use this for initialization
    void Start()
    {
        //get the game object that has all the instruction audio clips
        instrSound = GameObject.Find("InstructionSound").GetComponent<InstructionSound>();
        SoundSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void PlayQuitSound()
    {
        SoundSource.Stop();
        SoundSource.PlayOneShot(instrSound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.Thanks));
    }

    // no need to wait for the go introduction to finish before changing scene
    // so no need for coroutin and yield
    public void PlayGoLongSound()
    {
        SoundSource.PlayOneShot(instrSound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.GoLong));
    }

    
}
