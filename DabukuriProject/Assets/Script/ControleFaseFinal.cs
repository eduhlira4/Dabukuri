using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleFaseFinal : MonoBehaviour {

	public string scene;
	public int qtdPontos, interruptor;
	public GameObject BotaoAvancar;
	public AudioClip aplausos;
	public AudioSource tocadorR;

	// Use this for initialization
	void Start () {
		interruptor = 1;
		DropMe.passoscertos = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (DropMe.passoscertos == qtdPontos && interruptor == 1) {
			Debug.Log (DropMe.passoscertos);
			Invoke ("telaVitoria", 1);
			interruptor = 0;
		}
		
	}
	void telaVitoria(){
		//SceneManager.LoadScene (scene);
		BotaoAvancar.SetActive(true);
		tocadorR.PlayOneShot (aplausos);

	}
}
