using UnityEngine;
using System.Collections;

public class scale : MonoBehaviour {

	Camera cam;

	void Start () 
	{
		cam = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ();
	}
	
	void Update () 
	{
		transform.localScale = new Vector3(cam.orthographicSize/2 * (Screen.width/Screen.height),cam.orthographicSize/2,0f);
	}
}
