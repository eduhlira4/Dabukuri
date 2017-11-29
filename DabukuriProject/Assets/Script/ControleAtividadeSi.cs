using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleAtividadeSi : MonoBehaviour {

	public GameObject[] imagens;
	public int index;
	public GameObject letraAtiva;
	//private bool botaoAtivar;

	// Use this for initialization
	void Start () {
		index = 0;
		letraAtiva = imagens[index];
		trocarImagens();
	}
	
	// Update is called once per frame
	void Update () {
		if (DropMe.podepassar == 1) {
			index = index + 1;
			Invoke ("trocarImagens", 2);
			DropMe.podepassar = 0;
			if (index == 6) {
				SceneManager.LoadScene ("Parabens");
			}
		}
	}

	public void trocarImagens()
	{
		letraAtiva.SetActive(false);
		letraAtiva = imagens[index];
		letraAtiva.SetActive(true);
	}

}
