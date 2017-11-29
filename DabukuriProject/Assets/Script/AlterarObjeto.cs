using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlterarObjeto : MonoBehaviour {

	public Image objeto, nomeTrocar;
	public AudioSource tocador;
	public AudioClip somObjetoTocar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TrocarImagem(Sprite Objeto){

		objeto.sprite = Objeto;
	}
	public void TrocarNome (Sprite Nome){
		nomeTrocar.sprite = Nome;
	}
	public void MudaarSom(AudioClip somObjeto){
		somObjetoTocar = somObjeto;
	}

	public void tocarSom(){
		Debug.Log ("tocarosom");
		tocador.PlayOneShot (somObjetoTocar);
	}
}
