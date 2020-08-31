using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

	public float speed = 10f;
	public Rigidbody rb;
	private Vector3 pos;
	public AudioClip a;
	private float jumpspeed=10f;

	[SerializeField] [Range(0,1)] float soundvalue=0.55f;




	void Start () {
		
		rb = this.GetComponent<Rigidbody> ();
		pos = new Vector3 (0f,5f,0f);
		Cursor.lockState = CursorLockMode.Locked;
	
	}
	
	// Update is called once per frame
	void Update () {
		jump ();

		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;


		transform.Translate (straffe, 0, translation);

		if (Input.GetKeyDown ("escape")) {
			Cursor.lockState = CursorLockMode.None;
		}


	}

	

		public void jump(){
			if(Input.GetKey(KeyCode.Space)){
				transform.Translate (pos*jumpspeed*Time.deltaTime);
			AudioSource.PlayClipAtPoint (a,Camera.main.transform.position,soundvalue);


			}




		}



	public void OnCollisionEnter(Collision c){

		if (c.gameObject.tag == "villian") {
			Destroy (gameObject);
			SceneManager.LoadScene (9);
		}

	}

	public void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="Demon"){
			Destroy(gameObject);
			SceneManager.LoadScene (9);

		}


	}



}