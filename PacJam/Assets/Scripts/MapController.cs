using UnityEngine;
using System.Collections;

public class MapController : MonoBehaviour {

	public GameObject mapTile;
	int mapSizeX = 10;
	int mapSizeY = 10;

	// Use this for initialization
	void Awake () {

		BuildMap ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void BuildMap(){
		for (int i = 0; i < mapSizeX; i++) {
			for (int j = 0; j < mapSizeY; j++) {
				GameObject obj = (GameObject)Instantiate (mapTile, new Vector3 (i, j, 0), Quaternion.identity);
				obj.transform.SetParent (this.gameObject.transform);
			}
		}
	}
}
