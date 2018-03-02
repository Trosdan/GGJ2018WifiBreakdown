using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour {

	public GameObject bloco;
	public GameObject orgBlocos;
	public BoxCollider2D myBoxCollider;
	public List<Transform> blocos;

	public float Colunas;
	public float Linhas;

	// Use this for initialization
	void Awake () {
		CriarBlocos ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CriarBlocos(){
		float sizeX = myBoxCollider.size.x;
		float sizeY = myBoxCollider.size.y;
		float sizeBlockX = sizeX / Colunas;
		float sizeBlockY = sizeY / Linhas;
		float auxSizeX = (-(sizeX/2)+sizeBlockX/2);
		float auxSizeY = (-(sizeY/2)+sizeBlockY/2);
		Vector3 posDinamic = transform.localPosition;
		for (float x = 0; x < Colunas; x++) {
			GameObject auxBlocoX = Instantiate (bloco, new Vector3(posDinamic.x+auxSizeX, posDinamic.y+auxSizeY, posDinamic.z), Quaternion.identity, orgBlocos.transform);
			blocos.Add (auxBlocoX.transform);
			for (float y = 0; y < Linhas; y++){
				GameObject auxBlocoY = Instantiate (bloco, new Vector3(posDinamic.x+auxSizeX, posDinamic.y+auxSizeY, posDinamic.z), Quaternion.identity, orgBlocos.transform);
				blocos.Add (auxBlocoY.transform);
				auxSizeY += sizeBlockY;
			}
			auxSizeX += sizeBlockX;
			auxSizeY = (-(sizeY/2)+sizeBlockY/2);
		}
		orgBlocos.transform.rotation = Quaternion.Euler (new Vector3 (55.3f, 0f, 45f));
		myBoxCollider.transform.localRotation = Quaternion.Euler (new Vector3 (55.3f, 0f, 45f));
	}
}
