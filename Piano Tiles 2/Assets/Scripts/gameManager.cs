using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gameManager : MonoBehaviour {

	public int ProbOfBlank;
	public float tileInvokeDelay = 2.0f;
	public float tileInvokeRate = 1.0f;
	public GameObject whiteTile;
	public GameObject blackTile;
	List<Transform> whiteTransformPoints;


	GameObject pointsParent;
	public Transform[] points;

	void Start () 
	{
		InvokeRepeating ("tileChooser", 0, tileInvokeRate);
		pointsParent = GameObject.FindGameObjectWithTag ("Points Parent");
		Camera mainCamera = GetComponent<Camera> ();
		Vector3 pointsPosition = mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth / 2, mainCamera.pixelHeight, 0));
		pointsParent.transform.position = pointsPosition;
		/*for (int i = 0; i <= pointsParent.transform.childCount; i++) {
			points.Add(pointsParent.transform.GetChild(i));
		}*/

	
	

	}

	void Update()
	{

	}
	
	void tileChooser () 
	{

		foreach (Transform transPoint in points) {
			Debug.Log(transPoint.gameObject.name);
		}

		int blankInt = Random.Range (0, ProbOfBlank);
		if (blankInt != 0) {
			int blackTileInt = Random.Range (0, pointsParent.transform.childCount);
			whiteTransformPoints.Remove(points[blackTileInt]);
			foreach(Transform whitePoint in whiteTransformPoints)
			{
				Instantiate(whiteTile, whitePoint.position, whiteTile.transform.rotation);
			}


		} else {
			Debug.Log("All Whites");
		}
	}
}
