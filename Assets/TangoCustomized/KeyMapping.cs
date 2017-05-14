﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMapping : MonoBehaviour {

	//public Selection Attack1;

	//public Pokeball[] FocusedObjects;

	int stage = 0;

	public bool isIPressed;
	public bool isOPressed;
	public bool isPPressed;
	public bool isCPressed;
	public bool isVPressed;
	public bool isSpacePressed;
	public bool isEPressed;
	public bool isRPressed;
	public bool isTPressed;
	public bool isHPressed;
	public bool isYPressed;
	public bool isKPressed;
	public bool isLPressed;



	// Use this for initialization
	void Start () {
		isIPressed = false;
		isOPressed = false;
		isPPressed = false;
		isCPressed = false;
		isVPressed = false;
		isHPressed = false;
		isSpacePressed = false;
		isEPressed = false;
		isRPressed = false;
		isTPressed = false;
		isYPressed = false;
		isKPressed = false;
		isLPressed = false;
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown (KeyCode.S)) {
//			switch (stage) {
//			case 0:
//				foreach (Pokeball FocusedObject in FocusedObjects) {
//					if (!FocusedObject.GetComponent<Pokeball> ().Check_Ready ()) {
//						FocusedObject.GetComponent<Pokeball> ().Select ();
//						Debug.Log ("Gaze");
//					}
//				}
//				break;
//			default:
//				break;
//			}
//			Attack1.OnPressed = true;
//		}
	}

	public void KeyPressed(string k){
		if(k.Equals("I"))
			isIPressed = true;
		
		if(k.Equals("O"))
			isOPressed = true;

		if(k.Equals("P"))
			isPPressed = true;

		if(k.Equals("C"))
			isCPressed = true;

		if(k.Equals("V"))
			isVPressed = true;

		if(k.Equals("H"))
			isHPressed = true;

		if(k.Equals("space"))
			isSpacePressed = true;

		if(k.Equals("E"))
			isEPressed = true;

		if(k.Equals("R"))
			isRPressed = true;

		if(k.Equals("T"))
			isTPressed = true;

		if(k.Equals("Y"))
			isYPressed = true;

		if(k.Equals("K"))
			isKPressed = true;

		if(k.Equals("L"))
			isLPressed = true;

	}

	public void PokeContinue(){
		switch (stage) {
		case 0:
			isIPressed = true;
			++stage;
			break;
		case 1:
			isPPressed = true;
			++stage;
			break;
		case 2:
			// might take gaze into consideration
			isCPressed = true;

			++stage;
			break;
		case 3:
		case 5:
			// put it into blue target
			isOPressed = true;
			++stage;
			break;
		case 4:
			isLPressed = true;
			++stage;
			break;
		default:
			break;
		}
	}

		public void PokeAttack(){
			// four buttons for attacking
			isRPressed = true;
		}
}
