using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public bool gameRodando = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		UpdatePotencia ();
	}

	public Vector3 GetMousePos(){
		Vector3 posMouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		posMouse = new Vector3 (posMouse.x, posMouse.y, posMouse.z+1);

		return posMouse;
	}

	void ClickSound(){
		if (Input.GetMouseButtonDown (0)) {
			
		}
	}

	public void FaseConcluida (){
		GameInst.Instance.uiController.ActiveUIParabens ();
	}

	public void UpdatePotencia(){
		if (GameInst.Instance.sinalController.potenciaSinal > 80) {
			GameInst.Instance.uiController.ActiveUIParabens ();
			gameRodando = false;
		}
	}
}
