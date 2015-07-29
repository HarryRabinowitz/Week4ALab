using UnityEngine;
using System.Collections;

public class gridInstantiate : MonoBehaviour {

	public Transform floorPrefab;
	public Transform wallPrefab;

	float rando;
	float chanceToFloor;
	public Transform chanceToPath;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			chanceToFloor = Random.Range (0f, 100f);
			
			for ( int x=0; x < 200; x++) {
				for ( int z=0; z < 5; z++) {
					Vector3 pos = new Vector3 (x * 5f, 0f, z * 5f) + transform.position;
					rando = Random.Range (0f, 100f);
					if (rando > 69f) {
						Transform newClone = (Transform)Instantiate (floorPrefab, pos, transform.rotation);
					} else if (rando < 26f && rando > 5f) {
						Transform newClone = (Transform)Instantiate (wallPrefab, pos, transform.rotation);
					} else {
						Destroy (this.gameObject );
					}
				}
			}
			
			if ( chanceToFloor > Random.Range (0f, 100f)) {
				Transform newClone = (Transform)Instantiate (wallPrefab, transform.position, transform.rotation);
			}
		}

	}

