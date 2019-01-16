using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryPlaySound : MonoBehaviour {

    private InstructionSound instrSound;
    public AudioSource SoundSource { get; private set; }

    // Use this for initialization
    void Start()
    {
        //get the game object that has all the instruction audio clips
        GameObject isgo = GameObject.Find("InstructionSound");
        instrSound = isgo.GetComponent<InstructionSound>();
        SoundSource = GetComponent<AudioSource>();

        PlayInstructionSound();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void PlayInstructionSound() {
        SoundSource.PlayOneShot(instrSound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.MemoryInstruction));
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

    public void PlayCardMatchSound()
    {
        SoundSource.PlayOneShot(instrSound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.CardMatch));        
    }

    public void PlayCardMismatchSound()
    {
        SoundSource.PlayOneShot(instrSound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.TryAgain));
    }

    
    public void PlayCardSound(AudioClip ac) {
        SoundSource.PlayOneShot(ac);
    }
}
