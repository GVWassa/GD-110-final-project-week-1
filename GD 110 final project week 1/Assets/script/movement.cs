using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float ballAmt;

	 public GameObject selectedObj;

	 Rigidbody rb;
    
	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();

       
	}
	
	// Update is called once per frame
	void Update () {

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		Debug.DrawRay (ray.origin, ray.direction * 1000f, Color.green);

		RaycastHit ballSelect = new RaycastHit ();

//		if (Input.GetKey("up")) {
//		rb.AddForce(transform.forward * ballAmt);
//		}
//		if (Input.GetKey ("down")) {
//		rb.AddForce(-transform.forward * ballAmt);
//		}
//		if (Input.GetKey("left")) {
//		rb.AddForce(-transform.right * ballAmt);
//		}
//		if (Input.GetKey ("right")) {
//		rb.AddForce(transform.right * ballAmt);
//		}

		if (Physics.Raycast (ray, out ballSelect, 1000f, LayerMask.GetMask ("Player"))) {
		
			Debug.Log ("you hit ..." + ballSelect.collider.gameObject.name);

			if (Input.GetMouseButtonDown (0)) {

				selectedObj = ballSelect.collider.gameObject;

			}
		
//			if (Input.GetKey("up")) {
//				rb.AddForce(Vector3.forward * ballAmt);
//			}
//			if (Input.GetKey ("down")) {
//				rb.AddForce(-Vector3.forward * ballAmt);
//			}
//			if (Input.GetKey("left")) {
//				rb.AddForce(-Vector3.right * ballAmt);
//			}
//			if (Input.GetKey ("right")) {
//				rb.AddForce(Vector3.right * ballAmt);
//			}
		
		
		
		}

		if (Input.GetKey("up")) {
			rb.AddForce(Vector3.forward * ballAmt);
		}
		if (Input.GetKey ("down")) {
			rb.AddForce(-Vector3.forward * ballAmt);
		}
		if (Input.GetKey("left")) {
			rb.AddForce(-Vector3.right * ballAmt);
		}
		if (Input.GetKey ("right")) {
			rb.AddForce(Vector3.right * ballAmt);
		}


    }
}
