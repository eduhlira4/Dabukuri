using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FecharPopup : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FecharPopUp(GameObject popUp){
	
		popUp.SetActive (false);
	}
}
