using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Redgoal : MonoBehaviour {

	public Text redIsdone;
	public Text countText;


	private int Redball;
	// Use this for initialization
	void Start () {
		Redball = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider redzone){

		if ( redzone.gameObject.CompareTag("red")){
		 Debug.Log ("redball is in the red");
			Redball = Redball + 1;


		}
	}

	void OnTriggerStay(Collider redzone){

		SetCountText ();
	}

	void OnTriggerExit(Collider redzone){

		if (redzone.gameObject.CompareTag ("red")) {
			Redball = Redball - 1;
		}
	}







	void SetCountText(){

		countText.text = "Redball:" + Redball.ToString ();

		if (Redball >= 3) {
			redIsdone.text = "done";
		}
	}
}
