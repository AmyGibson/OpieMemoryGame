using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordRepPlaySound : MonoBehaviour {

    public AudioSource SoundSource { get; private set; }
    private InstructionSound instrSound;
    public AudioClip record_beep;

    // Use this for initialization
    void Start () {
        instrSound = GameObject.Find("InstructionSound").GetComponent<InstructionSound>();
        SoundSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayQuitSound()
    {
        SoundSource.Stop();
        SoundSource.PlayOneShot(instrSound.GetInstructionAudioClip((int)InstructionSound.InstructionAC.Thanks));
        //StartCoroutine(PlayQuitSoundCo());
    }

    /*
    IEnumerator PlayQuitSoundCo()
    {
        _sound_source.Stop();
        _sound_source.PlayOneShot(instrSound.GetInstructionAudioClip("thankyou"));
        yield return new WaitWhile(() => _sound_source.isPlaying);
        UnityEngine.SceneManagement.SceneManager.LoadScene("profiles_scene");
    }*/

    public void PlayCardSound(AudioClip ac)
    {
        SoundSource.Stop();
        SoundSource.PlayOneShot(ac);
        //StartCoroutine(PlayCardSoundCo(ac));
    }
    /*
    private IEnumerator PlayCardSoundCo(AudioClip ac)
    {
        yield return new WaitWhile(() => _sound_source.isPlaying);
        _sound_source.PlayOneShot(ac);
    }*/


    public void PlayRecordedSound(AudioClip ac)
    {
        SoundSource.Stop();
        SoundSource.PlayOneShot(ac);
        //StartCoroutine(PlayCardSoundCo(ac));
    }
    /*
    private IEnumerator PlayRecordedSoundCo(AudioClip ac)
    {
        yield return new WaitWhile(() => _sound_source.isPlaying);
        _sound_source.PlayOneShot(ac);
    }*/

   

    public void PlayRecordSound()
    {
        StartCoroutine(PlayRecordSoundCo());
    }

    private IEnumerator PlayRecordSoundCo()
    {
        SoundSource.PlayOneShot(instrSound.GetInstructionAudioClip((int)InstructionSound.InstructionAC.Repeat));
        yield return new WaitWhile(() => SoundSource.isPlaying);
        SoundSource.PlayOneShot(record_beep);
    }

}
