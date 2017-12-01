using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VerificarVitoria : MonoBehaviour {
	public string scene;
	public AudioSource Tocador;
	public AudioClip aplausos;
	private int interruptor;

	// Use this for initialization
	void Start () {
		interruptor = 1;
		DropMe.passoscertos = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (DropMe.passoscertos == 3 && interruptor == 1) {
			Tocador.PlayOneShot (aplausos);
			interruptor = 0;
			Invoke ("telaVitoria", 2);

		}
	}

	void telaVitoria(){
		SceneManager.LoadScene (scene);
	
	}
}
