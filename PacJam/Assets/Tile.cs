using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public GameObject highlight;
	Cabinet cabOnTile = null;
	Color green = new Color(0f, 1f, 0f, 0.6f);
	Color red = new Color(1f, 0f, 0f, 0.6f);

	// Use this for initialization
	void Start () {
		highlight.GetComponent<SpriteRenderer> ().color = green;
	}
	
	// Update is called once per frame


	//TODO: If it is placeable be green, if not be red
	void OnMouseEnter(){
		highlight.SetActive (true);
	}

	void OnMouseExit(){
		highlight.SetActive (false);
	}

	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			if (cabOnTile == null) { 
				cabOnTile = GameManager.instance.PlaceObject (gameObject.transform.position);
				highlight.GetComponent<SpriteRenderer> ().color = red;
			}
		} else if (Input.GetMouseButtonDown (1)) {
			if (cabOnTile != null) {
				cabOnTile.DestroyCabinet ();
				cabOnTile = null;
			}
		
		}
	}
}
