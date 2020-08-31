using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class particle : MonoBehaviour {


	public Text t;
	private int score=0;

	void Start(){
		
	}

	void Update(){

		t.text = "Score" + ":"+""+ score.ToString();

	}


	public void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "collect") {
			score += 1;
			Destroy (col.gameObject);

		}
	}


}
