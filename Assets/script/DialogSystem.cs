using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour {

	public GameObject Dialogbox;
	public string DialogText;
	public bool DialogActive;
	public Text DialogScene;



	void Start () {
		
	}
	 
	// Update is called once per frame
	void Update () {

		if(DialogActive){
			
			if(Dialogbox.activeInHierarchy){
				Dialogbox.SetActive (false);


			}

			else{
				Dialogbox.SetActive (true);
				DialogScene.text = DialogText;

			}

		}

		if(Input.GetKeyDown(KeyCode.F)){
			DialogActive = !DialogActive;


		}
	
	}

}



