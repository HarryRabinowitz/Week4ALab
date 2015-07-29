using UnityEngine;
using System.Collections;

public class pathInstantiate : MonoBehaviour {


	private int counter;

	//public GameObject floorModule;

	//to set with our inspector
	public Transform floorPrefab;
	public Transform wallPrefab;

	//For random percentages
	float chanceToWall;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		//Between 0 and 100
		chanceToWall = Random.Range (0f, 100f);

		//Procgen
		if ( counter < 100f ) {
			float randomNumber = Random.Range (0.0f, 1.0f);
				if (randomNumber < 0.25f) {
				transform.Rotate(0f, 90f, 0f);
			} else if (randomNumber > 0.24f && randomNumber < 0.6f )
				transform.Rotate (0f, -90f, 0f);
			Transform newClone = (Transform)Instantiate (floorPrefab, transform.position, transform.rotation);

			transform.localPosition += transform.forward * 5f;
			counter++;
		} else {
			//Destroy (this.gameObject );
			if (Input.GetKeyDown (KeyCode.R) ) {
				Application.LoadLevel ( Application.loadedLevel );
				}
			}
		//Meaning there is only a 50% for walls. chancetoWall, which is between 0 and 100, has to be greater than
		//a random number between 0 and 200.

		if ( chanceToWall > Random.Range (0f, 200f)) {
			Transform newClone = (Transform)Instantiate (wallPrefab, transform.position, transform.rotation);
		}

	}

}

	

