using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {
	[SerializeField] private Sprite filled_star = null;


	


	public void Setfilled() {
	
		SpriteRenderer sr = transform.gameObject.GetComponent<SpriteRenderer> ();
		sr.sprite = filled_star;
	}


}
