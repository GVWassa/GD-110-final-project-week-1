using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePawn : MonoBehaviour {

	public Color myMaterial;

	// Use this for initialization
	void Start () {
		myMaterial = Color.white;
		
	}
	
	// Update is called once per frame
	void Update () {
		myMaterial = Color.Lerp(Color.green, Color.red, 1.0f);
	}
}

// this method will apparentlychange the color of the for a second and it will go bak to his normal colr 
