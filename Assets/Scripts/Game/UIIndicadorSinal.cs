using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIIndicadorSinal : MonoBehaviour {

	public GameObject semSinal;

	public GameObject sinal;
	public GameObject sinal1;
	public GameObject sinal2;
	public GameObject sinal3;
	public GameObject sinal4;
	public AudioClip[] efx;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameInst.Instance.sinalController.potenciaSinal == 0) {
			semSinal.SetActive (true);
			sinal.SetActive (false);
			sinal1.SetActive (false);
			sinal2.SetActive (false);
			sinal3.SetActive (false);
			sinal4.SetActive (false);
		} if (GameInst.Instance.sinalController.potenciaSinal > 0) {
			semSinal.SetActive (false);
			sinal.SetActive (true);
			sinal1.SetActive (false);
			sinal2.SetActive (false);
			sinal3.SetActive (false);
			sinal4.SetActive (false);
		} if (GameInst.Instance.sinalController.potenciaSinal > 20) {
			semSinal.SetActive (false);
			sinal.SetActive (true);
			sinal1.SetActive (true);
			sinal2.SetActive (false);
			sinal3.SetActive (false);
			sinal4.SetActive (false);
		} if (GameInst.Instance.sinalController.potenciaSinal > 40) {
			semSinal.SetActive (false);
			sinal.SetActive (true);
			sinal1.SetActive (true);
			sinal2.SetActive (true);
			sinal3.SetActive (false);
			sinal4.SetActive (false);
		} if (GameInst.Instance.sinalController.potenciaSinal > 60) {
			semSinal.SetActive (false);
			sinal.SetActive (true);
			sinal1.SetActive (true);
			sinal2.SetActive (true);
			sinal3.SetActive (false);
			sinal4.SetActive (false);
		} if (GameInst.Instance.sinalController.potenciaSinal > 80) {
			semSinal.SetActive (false);
			sinal.SetActive (true);
			sinal1.SetActive (true);
			sinal2.SetActive (true);
			sinal3.SetActive (true);
			sinal4.SetActive (false);
		} if (GameInst.Instance.sinalController.potenciaSinal == 100) {
			semSinal.SetActive (false);
			sinal.SetActive (true);
			sinal1.SetActive (true);
			sinal2.SetActive (true);
			sinal3.SetActive (true);
			sinal4.SetActive (true);
		}
	}
}
