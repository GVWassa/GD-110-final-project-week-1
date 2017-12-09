using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yellowgoal : MonoBehaviour {

	public Text yellowISdone;
	public Text countText;


	private int yellowball;
	// Use this for initialization
	void Start () {
		yellowball = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider yellowzone){

		if ( yellowzone.gameObject.CompareTag("yellow")){
		 Debug.Log ("yellowball is in the yellow");
			yellowball = yellowball + 1;


		}
	}

	void OnTriggerStay(Collider yellowzone){

		SetCountText ();
	}

	void OnTriggerExit(Collider yellowzone){

		if (yellowzone.gameObject.CompareTag ("yellow")) {
			yellowball = yellowball - 1;
		}
	}







	void SetCountText(){

		countText.text = "Yellowball:" + yellowball.ToString ();

		if (yellowball >= 3) {
			yellowISdone.text = "done";



			}

	

		
 }
}
