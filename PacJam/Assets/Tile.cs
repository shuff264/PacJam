using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public GameObject highlight;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//TODO: If it is placeable be green, if not be red
	void OnMouseEnter(){
		highlight.SetActive (true);
	}

	void OnMouseExit(){
		highlight.SetActive (false);
	}
}
