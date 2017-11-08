using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlterarObjeto : MonoBehaviour {

	public Image objeto, nomeTrocar;

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
}
