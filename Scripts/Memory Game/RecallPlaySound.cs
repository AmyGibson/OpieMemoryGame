using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecallPlaySound : MonoBehaviour {

    private InstructionSound instrSound;
    public AudioSource SoundSource { get; private set; }

    // Use this for initialization
    void Start () {
        //get the game object that has all the instruction audio clips
        instrSound = GameObject.Find("InstructionSound").GetComponent<InstructionSound>();
        SoundSource = GetComponent<AudioSource>();

        PlayInstructionSound();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void PlayInstructionSound()
    {
        SoundSource.PlayOneShot(instrSound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.RecallInstruction));
    }

    public void PlayQuitSound()
    {
        SoundSource.Stop();
        SoundSource.PlayOneShot(instrSound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.Thanks));
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


    public void PlayCardSound(AudioClip ac)
    {
        SoundSource.Stop();
        SoundSource.PlayOneShot(ac);
    }

}
