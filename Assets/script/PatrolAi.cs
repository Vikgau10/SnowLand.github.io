using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolAi : MonoBehaviour {

	public Transform[] movespots;
	public float speed=2f;
	public float starttime;
	private float waittime;
	private int randomspot;


	void Start () {
		randomspot = Random.Range (0,movespots.Length);

	}
	

	void Update () {
		transform.position = Vector3.MoveTowards (transform.position,movespots[randomspot].position,speed*Time.deltaTime);
		if (Vector3.Distance (transform.position,movespots [randomspot].position) <= 0.2f) {
			if (waittime <= 0) {
				waittime = starttime;
				randomspot = Random.Range (0,movespots.Length);

			} else {
				waittime -= Time.deltaTime;


			}

		}



	}
}
