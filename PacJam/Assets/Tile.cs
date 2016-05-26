using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public GameObject highlight;
	bool filled = false;
	Color green = new Color(0f, 1f, 0f, 0.6f);
	Color red = new Color(1f, 0f, 0f, 0.6f);

	// Use this for initialization
	void Start () {
		highlight.GetComponent<SpriteRenderer> ().color = green;
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

	void OnMouseDown(){
		if (!filled) { 
			GameManager.instance.PlaceObject (gameObject.transform.position);
			filled = true;
			highlight.GetComponent<SpriteRenderer> ().color = red;
		}
	}
}
