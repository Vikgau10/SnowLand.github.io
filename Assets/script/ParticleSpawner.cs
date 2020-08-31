using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour {

	public GameObject particles;  

	void Start () {

		GameObject s = Instantiate (particles,transform.position,Quaternion.identity);
		transform.position = s.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
