using UnityEngine;
using System.Collections;

public class CabinetInitialiser : MonoBehaviour {

	public GameObject cabinetPrefab;
	Cabinet cabinet;
	GameObject cabinetGO;

	// Use this for initialization
	void Start () {

		cabinetGO = (GameObject)Instantiate (cabinetPrefab);
		cabinet = cabinetGO.GetComponent<Cabinet> ();
		cabinet.Inititalise (5, 10, 1, 50, "Test", "Testing cabinet");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
