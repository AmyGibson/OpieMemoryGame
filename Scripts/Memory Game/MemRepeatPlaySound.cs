using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemRepeatPlaySound : MonoBehaviour {

    private InstructionSound instr_sound;
    public AudioSource SoundSource { get; private set; }
    public AudioClip record_beep;

    // Use this for initialization
    void Start()
    {
        //get the game object that has all the instruction audio clips
        instr_sound = GameObject.Find("InstructionSound").GetComponent<InstructionSound>();
        SoundSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    

    public void PlayQuitSound()
    {
        SoundSource.Stop();
        SoundSource.PlayOneShot(instr_sound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.Thanks));
    }


    public void PlayRecordSound() {
        //play repeat
        StartCoroutine(PlayRecordSoundCo());
        //play beep sound
    }

    private IEnumerator PlayRecordSoundCo() {
        SoundSource.PlayOneShot(instr_sound.GetInstructionAudioClip(
            (int)InstructionSound.InstructionAC.Repeat));
        yield return new WaitWhile(() => SoundSource.isPlaying);
        SoundSource.PlayOneShot(record_beep);
    }


  
    public void PlayCardSound(AudioClip ac)
    {
        SoundSource.PlayOneShot(ac);
        //StartCoroutine(PlayCardSoundCo(ac));
    }
  
    /*
    private IEnumerator PlayCardSoundCo(AudioClip ac)
    {
        yield return new WaitWhile(() => SoundSource.isPlaying);
        SoundSource.PlayOneShot(ac);
    }*/
}
