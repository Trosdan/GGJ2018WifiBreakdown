using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinalController : MonoBehaviour {

	public GameObject modem;
	public GameObject personagem;
	public float raio;
	public List<GameObject> sinais;
	public List<GameObject> sinaisTrue = new List<GameObject>();
	public float potenciaSinal;

	GameObject proxSinal;
	List<GameObject> auxSinais;

	// Use this for initialization
	void Start () {
		potenciaSinal = UpdatePotencia ();
	}
	
	// Update is called once per frame
	void Update () {
		potenciaSinal = Mathf.Lerp(potenciaSinal, UpdatePotencia (), 0.1f);
	}

	public void UpdateSinal(){

		LimparLista (sinaisTrue);

		proxSinal = MaisProximo (modem);
		if (proxSinal != null) {
			while (true) {
				if (proxSinal != null) {
					proxSinal = MaisProximo (proxSinal);
				} else {
					break;
				}
			}
		}



	}


	public GameObject MaisProximo(GameObject deMim){
		GameObject sinalProx = null;
		float menorDist = 3000000;
		foreach(GameObject auxSinal in sinais){
			
			float dist = Vector2.Distance (auxSinal.transform.position, deMim.transform.position);
			if(dist < menorDist){
				if (auxSinal.GetComponent<Sinal> ().existeSinal) {
					// faça nada
				} else {
					menorDist = dist;
					sinalProx = auxSinal;
				}
			}
		}
		if (menorDist < raio) {
			sinalProx.GetComponent<Sinal> ().SetSinalTrue ();
			sinalProx.GetComponent<Sinal> ().dist = menorDist;
			sinaisTrue.Add (sinalProx);
			return sinalProx;
		}
		return null;
	}

	public void LimparLista(List<GameObject> auxSinaisTrue){
		foreach (GameObject auxSinal in auxSinaisTrue) {
			auxSinal.GetComponent<Sinal> ().SetSinalFalse ();
		}
		auxSinaisTrue.Clear ();
		auxSinaisTrue.Add (modem);
	}

	public float UpdatePotencia(){
		float potencia = 100;
		GameObject sinalProx = null;
		float menorDist = 3000000000;
		foreach (GameObject auxSinal in sinais) {
			float dist = Vector2.Distance (auxSinal.transform.position, personagem.transform.position);
			if (dist < menorDist) {
				if (auxSinal.GetComponent<Sinal> ().existeSinal) {
					menorDist = dist;
					sinalProx = auxSinal;
				}
			}
		}
		if (menorDist < 22) {
			//print (sinalProx.name);
			//print (menorDist);
			potencia = -(((menorDist * 100) / 22)-100);

		} else {
			potencia = 0;
		}

		return potencia;
	}
}
