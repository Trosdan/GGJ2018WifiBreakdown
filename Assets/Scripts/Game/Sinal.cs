using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinal : MonoBehaviour {

	public bool existeSinal;
	public bool modem;
	public GameObject Alerta;
	public float dist;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetSinalTrue(){
		existeSinal = true;
		Alerta.SetActive (true);
	}

	public void SetSinalFalse(){
		Alerta.SetActive (false);
		existeSinal = false;
	}
}

