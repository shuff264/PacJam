﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	Dictionary<string, Cabinet> cabinetDic; 
	public List<Cabinet> cabinetsInLevel;

	public static GameManager instance;
	public GameObject levelsCabs;

	int playerMoney = 1000;

	// Use this for initialization
	void Awake () {
		instance = this;
		cabinetDic = new Dictionary<string, Cabinet> ();
		cabinetsInLevel = new List<Cabinet> ();

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(playerMoney);

		if(Input.GetKeyDown(KeyCode.Space)){
			for(int i = 0; i < cabinetsInLevel.Count; i++){
				SubtractMoney(cabinetsInLevel[i].ReturnRunningCost());
			}

		}

	}

	public void AddCabinetToDic(Cabinet c){
		c.gameObject.name = c.cName;
		cabinetDic.Add (c.cName, c);
	}

	public Cabinet PlaceObject(Vector3 tilePos){
		//instatiate to from cab dic at tile pos locale

		Cabinet cab = (Cabinet)Instantiate(cabinetDic["Test"], tilePos, Quaternion.identity);
		cab.gameObject.transform.SetParent (levelsCabs.transform);
		cab.gameObject.SetActive (true);
		cabinetsInLevel.Add(cab);


		return cab;
	}

	public void AddMoney(int n){
		playerMoney += n;
	}

	public void SubtractMoney(int n){
		playerMoney -= n;
	}

	public int ReturnPlayerMoney(){
		return playerMoney;
	}

}
