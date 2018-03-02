using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSinal : MonoBehaviour {

	public float potenciaSinal;

	BoxCollider2D myBoxCollider2D;

	// Use this for initialization
	void Start () {
		myBoxCollider2D = GetComponent<BoxCollider2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		CrescimentoSinal ();
	}

	void CrescimentoSinal(){
		if (potenciaSinal > 0) {
			myBoxCollider2D.size = new Vector2 ((myBoxCollider2D.size.x+1f), myBoxCollider2D.size.y);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Barreira")){
			potenciaSinal -= 1;
		}
	}
}
