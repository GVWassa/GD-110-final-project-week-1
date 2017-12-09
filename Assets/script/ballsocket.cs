using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballsocket : MonoBehaviour {
	public Text blueISdone;
	public Text countText;
	 
	private int Blueball;

	// Use this for initialization
	void Start () {
		Blueball = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider bluezone){

		if ( bluezone.gameObject.CompareTag("blue")){
		   Debug.Log ("blueball is in the blue");

			Blueball = Blueball + 1;

		
		}
	}

	void OnTriggerStay(Collider bluezone){

		SetCountText ();
	}

	void OnTriggerExit(Collider bluezone){

		if (bluezone.gameObject.CompareTag ("blue")) {
			Blueball = Blueball - 1;
		}
	}







	void SetCountText(){

		countText.text = "Blueball:" + Blueball.ToString ();

		if (Blueball >= 3) {
			blueISdone.text = "done";
		}
	}

}
