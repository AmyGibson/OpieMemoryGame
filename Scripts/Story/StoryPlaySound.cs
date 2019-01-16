using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPlaySound : MonoBehaviour {

    public AudioSource SoundSource { get; private set; }
    private InstructionSound instrSound;

    // Use this for initialization
    void Start()
    {
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


    public void PlayStorySound(AudioClip ac)
    {
        SoundSource.Stop();
        SoundSource.PlayOneShot(ac);
    }
    

}
