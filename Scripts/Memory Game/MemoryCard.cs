using UnityEngine;
using System.Collections;

public class MemoryCard : MonoBehaviour {
    public GameObject cardBack = null;    
	private SceneController controller = null;
	public AudioClip cardFlipSound = null;
	private string transcription = null;

	private AudioClip cardSound = null;
    public int CardID { get; private set; }


    private void Awake()
    {
        controller = GameObject.Find("Scene Controller").GetComponent<SceneController>();
    }



    private GameObject GetCardFront()
	{
		for (int i = 0; i < gameObject.transform.childCount; i++) {
			GameObject child = gameObject.transform.GetChild(i).gameObject;
			if (child != cardBack) {
				return child;
			}
		}

		return null;
	}

	//Sets the ID number, image, sound and transcription of the card
	public void SetCard(int id, Sprite image, AudioClip cardSound, string transc) {
        CardID = id;
		
		SpriteRenderer sr = GetCardFront().GetComponent<SpriteRenderer>();
		sr.sprite = image;
		this.cardSound = cardSound;
		transcription = transc;
	}

	//Plays the card
	private IEnumerator FlipAndPlay()
	{
		//Display the transcription of the card and plays its associated sound
		controller.SetTranscription(transcription);
		GetComponent<AudioSource>().PlayOneShot (cardFlipSound);
		
		//Disables the card back to make the card image visible
		cardBack.SetActive(false);

		controller.CardRevealed(this);

		//Wait for flip sound to be finished
        yield return new WaitWhile(() => GetComponent<AudioSource>().isPlaying);
        
        //Send a finish event to enable transition
        controller.Finish();


		GetComponent<AudioSource>().PlayOneShot (cardSound);
        /*
		while (GetComponent<AudioSource>().isPlaying) {
			yield return null;	
		}*/
        yield return new WaitWhile(() => GetComponent<AudioSource>().isPlaying);

        controller.SetTranscription("");
		controller.Finish();
		yield break;
	}

	public void StartFlipAndPlay()
	{
		StartCoroutine(FlipAndPlay());
	}

	public void OnMouseDown() {
		if (cardBack.activeInHierarchy) {
			controller.SetCurrentCard(this);
			controller.Click();
		}
	}

	private IEnumerator FlipBack()
	{
		
		GetComponent<AudioSource>().PlayOneShot (cardFlipSound);
		cardBack.SetActive(true);

		/*while (GetComponent<AudioSource> ().isPlaying) {
			yield return null;
		}*/
        yield return new WaitWhile(() => GetComponent<AudioSource>().isPlaying);
        controller.Finish();
	}

	public void Unreveal() {
		//Debug.Log ("flip back");
		StartCoroutine (FlipBack());
	}
}
