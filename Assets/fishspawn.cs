using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishspawn : MonoBehaviour {

	public Vector3 startpos;

	void Start () {
     
		transform.position = startpos;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
