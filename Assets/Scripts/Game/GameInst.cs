using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInst : MonoBehaviour {

	private static GameInst instance;
	public static GameInst Instance{
		get{
			if(instance == null){
				instance = FindObjectOfType<GameInst> ();
			}
			return instance;
		}
	}

	public GameController gameController;
	public SinalController sinalController;
	public UIController uiController;	
	public AudioManager audioManager;
	public Table table;

}
