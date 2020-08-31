using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

	private int NumberOfObstacle = 10;
	public GameObject platform;
	public Vector3 Startpos;
	private float delay=0f;


	void Start () {

		Startpos = transform.position;

		spawn ();
		}


	public void spawn(){

		for(int i=0;i<=NumberOfObstacle;i++){
			Invoke("Direction",delay);
			delay += 2f;


		}

	}

	public void Direction(){

		Vector3 pos = new Vector3 (Random.Range (100f,204f), 0f, 0f);
		GameObject g = Instantiate (platform,Startpos+pos, Quaternion.identity);
		g.GetComponent<Rigidbody> ().velocity = new Vector3 (0f,0f,40f);
		transform.position = g.transform.position;
       
		Destroy (g, 15f);

	}

	}
	



