using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TocarSom : MonoBehaviour {


	public AudioSource TocadorDosom;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TocarBotao(AudioClip somPraTocar){
		TocadorDosom.PlayOneShot (somPraTocar);
	}
}
