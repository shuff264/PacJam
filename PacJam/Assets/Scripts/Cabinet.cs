using UnityEngine;
using System.Collections;

public class Cabinet : MonoBehaviour {

	public int playCost;
	public int runningCost;
	public int breakRate;
	public int buildCost;
	public string cName;
	public string description;

	public void Inititalise (int _playCost, int _runningCost, int _breakRate, int _buildCost, string _cName, string _description) { //TODO Extend to have sprite

		playCost = _playCost;
		runningCost = _runningCost;
		breakRate = _breakRate;
		buildCost = _buildCost;
		cName = _cName;
		description = _description;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void DestroyCabinet(){
		GameManager.instance.cabinetsInLevel.Remove(this);
		GameManager.instance.AddMoney(ReturnBuildCost() / 5);
		Destroy (this.gameObject);
	}

	public int ReturnPlayCost(){
		return playCost;
	}

	public int ReturnRunningCost(){
		return runningCost;
	}

	public int ReturnBreakRate(){
		return breakRate;
	}

	public int ReturnBuildCost(){
		return buildCost;
	}

	public string ReturnName(){
		return cName;
	}

	public string ReturnDescription(){
		return description;
	}


}
