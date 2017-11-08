using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSkip : MonoBehaviour {

	public int timeToSkip;
	public string scene;

	// Use this for initialization
	void Start () {
		Invoke ("SkipScene", timeToSkip);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SkipScene(){
		
		SceneManager.LoadScene (scene);
	}
}
