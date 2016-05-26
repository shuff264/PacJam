using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	Dictionary<string, Cabinet> cabinetDic; 

	public static GameManager instance;
	public GameObject levelsCabs;

	// Use this for initialization
	void Awake () {
		instance = this;
		cabinetDic = new Dictionary<string, Cabinet> ();
	}
	
	// Update is called once per frame
	void Update () {

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

		return cab;
	}
}
