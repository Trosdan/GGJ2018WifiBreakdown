using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour {

	public GameObject imagem;

	Transform myTransform;


	//	Booleans
	bool inTable = false;
//	bool estaOcupado = false;

	//	Posições
	Vector3 posIni;

	//Som
	public AudioClip[] efc;
	public AudioClip mouseDown;
	public AudioClip mouseUp;

	// Use this for initialization
	void Start () {
		myTransform = GetComponent<Transform> ();

		GameObject auxBloco = GetPointTable ();
		SetPositionTable (auxBloco);

	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDrag(){
		if (GameInst.Instance.gameController.gameRodando) {
			myTransform.position = GameInst.Instance.gameController.GetMousePos ();
		}


	}

	void OnMouseUp(){
		if(inTable){
			GameObject auxBloco = GetPointTable ();
			SetPositionTable (auxBloco);
		} else {
			SetPosition (posIni);
		}
		GameInst.Instance.sinalController.UpdateSinal ();
		GameInst.Instance.audioManager.PlayClip (mouseUp);

	}

	void OnMouseDown(){
		GameInst.Instance.audioManager.PlayClip (mouseDown);

	}

	void SetPositionTable(GameObject auxBloco){
		if (auxBloco.transform.childCount == 0) {
			myTransform.position = auxBloco.transform.position;
			posIni = auxBloco.transform.position;
			myTransform.parent = auxBloco.transform;

		} else {
			SetPosition (posIni);
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.CompareTag ("Table")) {
			inTable = true;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if (col.CompareTag ("Table")) {
			inTable = false;
		}
	}	

	GameObject GetPointTable(){
		List<Transform> auxBlocos = GameInst.Instance.table.blocos;
		Transform auxMenorBloco = null;
		float dist;
		float menorDist = 30f;
		for(int x=0; x<auxBlocos.Count; x++){
			dist = Vector2.Distance (auxBlocos [x].transform.position, myTransform.position);
			if (dist < menorDist) {
				menorDist = dist;
				auxMenorBloco = auxBlocos[x];
			}
		}
		//print (menorDist);
		return auxMenorBloco.gameObject;
		//myTransform.position = new Vector3(auxMenorBloco.position.x, auxMenorBloco.position.y, auxMenorBloco.position.z+1);

	}

	void SetParent(GameObject parent){

	}

	void SetPosition(Vector3 position){
		myTransform.position = position;
	}
}