using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	public GameObject uiParabens;

	public Scene asd;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadScene(string scene){
		SceneManager.LoadScene (scene);
		PlayerPrefs.SetFloat ("BackgroundSound", GameInst.Instance.audioManager.backgroundMusic.time);
	}

	public void ActiveUIParabens(){
		uiParabens.SetActive (true);
	}

	public void FecharGame(){
		Application.Quit ();
		PlayerPrefs.SetFloat ("BackgroundSound", 0f);
	}
}
