using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resolution : MonoBehaviour {

	public int Height;

	public int Width;


	public void SetWidth(int w){

		Width = w;

	}

	public void SetHeight(int h){

		Height = h;

	}

	public void SetResolution(){
		Screen.SetResolution (Width,Height,false);

	}

}
