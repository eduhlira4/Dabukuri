using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VerificarVitoria : MonoBehaviour {
	public string scene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (DropMe.passoscertos == 3) {
			Invoke ("telaVitoria", 2);
		}
	}

	void telaVitoria(){
		SceneManager.LoadScene (scene);
	
	}
}
