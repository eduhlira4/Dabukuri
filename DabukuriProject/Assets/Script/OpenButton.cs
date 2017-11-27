using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenButton : MonoBehaviour {

	public GameObject pausepanel;
	private bool ativo, ativo2, ativo3;

	// Use this for initialization
	void Start () {

		ativo = false;
		ativo2 = false;
		ativo3 = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ButtonOpen(GameObject botao){
		if (ativo == false) {
			botao.GetComponent<Animator> ().Play ("BotaoPlus");
			ativo = true;
		} else if(ativo == true){
			botao.GetComponent<Animator> ().Play ("CloseBotaoPlus");
			ativo = false;
		}

	}
	public void ButtonOpen2(GameObject botao2){
		if (ativo2 == false) {
			botao2.GetComponent<Animator> ().Play ("Botaoconfig");
			ativo2 = true;
			pausepanel.SetActive (true);
		} else if(ativo2 == true){
			botao2.GetComponent<Animator> ().Play ("CloseBotaoconfig");
			ativo2 = false;
			pausepanel.SetActive(false);
			Time.timeScale = 1;
		}

	}

	public void ButtonOpenConfig(GameObject botao3){
		if (ativo3 == false) {
			botao3.GetComponent<Animator> ().Play ("BotoesconfigMenu");
			ativo3 = true;

		} else if(ativo3 == true){
			botao3.GetComponent<Animator> ().Play ("CloseBotaoconfigMenu");
			ativo3 = false;

		}

	}

	public void AtivarPausePanel(){
		if (ativo2 == true) {
			Time.timeScale = 0;
		}
	}

}
