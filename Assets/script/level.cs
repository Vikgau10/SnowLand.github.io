using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour {

	// Use this for initialization

	public void OnCollisionEnter(Collision others){


		if(others.gameObject.tag=="Gate1"){
			SceneManager.LoadScene (2);


		}

		if(others.gameObject.tag=="Gate2"){
			SceneManager.LoadScene (3);


		}
			

		if(others.gameObject.tag=="Gate3"){
			SceneManager.LoadScene (4);


		}


		if(others.gameObject.tag=="Gate4"){
			SceneManager.LoadScene (5);


		}


		if(others.gameObject.tag=="winning"){
			SceneManager.LoadScene (8);


		}

	}




}
