using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Collections.Generic;

public class end_scene : MonoBehaviour {

	public Text text_written;
	// Use this for initialization
	void Start () {
	GameObject game=GameObject.Find("ProfileInfo");
	LogInfo log_info=game.GetComponent<LogInfo>();
	StreamReader r = File.OpenText(Application.persistentDataPath + "\\" + log_info.Filename);
    string info = r.ReadToEnd();
    r.Close();
	text_written.text=info;
	}
	
	// Update is called once per frame
	void Update () {
	foreach (Vector2 pos in getTouchOrMouseInteractions())
		{
			// Get the origin of the tap
			Vector2 origin = Camera.main.ScreenToWorldPoint(pos);
			float Xeye = 0.5f+origin.x/(22.5f-2f*origin.y);
			
			
		Opie.instance().head().set_linked_pose_and_eye_position(Xeye, 0.0f,
		Opie.Head.transition_action());
		}
	}
	
	public void Quit_app(){
		Application.Quit();
	}
	
	IEnumerable<Vector2> getTouchOrMouseInteractions()
	{
		if (Input.GetMouseButton(0))
		{
			yield return Input.mousePosition;
		}
		for (int i = 0; i < Input.touchCount; ++i)
		{
			if (Input.GetTouch(i).phase == TouchPhase.Began)
			{
				// Get the origin of the tap
				yield return Input.GetTouch(i).position;
			}
		}
	}
}
