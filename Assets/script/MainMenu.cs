using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	
	public bool GameisPaused;
	public GameObject PausePanel;



	void Start(){
		
	}



	void Update(){
		if (GameisPaused) {
			PausePanel.SetActive (true);
			Time.timeScale = 0f;


		} else {
			PausePanel.SetActive (false);
			Time.timeScale = 1f;


		}

		if(Input.GetKeyDown(KeyCode.Escape)){
			GameisPaused = !GameisPaused;

		}


	}


	public void Play(){
		SceneManager.LoadScene (1);


	}


	public void Instruction(){

		SceneManager.LoadScene (6);

	}
	public void Option(){

		SceneManager.LoadScene (7);

	}


	public void Quit(){

		Application.Quit ();

	}


	public void Menu(){
		SceneManager.LoadScene (0);


	}


	}


