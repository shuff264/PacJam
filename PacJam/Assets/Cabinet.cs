﻿using UnityEngine;
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
}
