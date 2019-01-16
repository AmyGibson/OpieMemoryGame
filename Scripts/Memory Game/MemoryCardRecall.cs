using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MemoryCardRecall : MonoBehaviour {
	[SerializeField] private AudioClip cardClickSound = null;
    [SerializeField] private SceneControllerRecall controller = null;

    private bool isactive;

    private int _id;
	public int id {
		get {return _id;}
	}
    

	//Set the image and sound of the card
	public void SetCard(int id, Sprite image) {
		_id = id;
        GetComponent<SpriteRenderer>().sprite = image;
        isactive = true;
	}


	public void OnMouseDown() {
        if (isactive)
        {
            controller.DeactivateAllCards();
            GetComponent<AudioSource>().PlayOneShot(cardClickSound);
            controller.StartCheckMatch(_id);
        }
    }


    public void Deactive() {
        isactive = false;
        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
        
    }

    public void Activate()
    {
        isactive = true;
        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        
    }

    



}
