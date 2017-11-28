using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleBotoes : MonoBehaviour {

    public GameObject[] imagens;
	public int index;
	public GameObject letraAtiva;

	// Use this for initialization
	void Start () {
		
		letraAtiva = imagens[index];
		trocarImagens();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void trocarImagens()
    {
		letraAtiva.SetActive(false);
		letraAtiva = imagens[index%imagens.Length];
		letraAtiva.SetActive(true);
    }

	public void percorrerIndex(int n){
		index+=n;
		trocarImagens();
	}
		
}
