using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peca : MonoBehaviour {

	public GameObject imagem;

	Transform myTransform;


	//	Booleans
	bool inTable = false;

	//	Posições
	Vector3 posIni;

	// Use this for initialization
	void Start () {
		myTransform = GetComponent<Transform> ();
		posIni = myTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDrag(){
		myTransform.position = GameInst.Instance.gameController.GetMousePos ();

	}

	void OnMouseUp(){
		if (inTable) {
			SetPositonTable ();
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

	void SetPositonTable(){
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
		myTransform.position = new Vector3(auxMenorBloco.position.x, auxMenorBloco.position.y, auxMenorBloco.position.z+1	);

	}

	void SetPosition(Vector3 position){
		myTransform.position = position;
	}
}