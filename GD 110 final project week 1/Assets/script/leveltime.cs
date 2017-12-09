using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leveltime : MonoBehaviour
{
    private int timeLeft = 180;
    public Text countdownText;

    
    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Time Left = " + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }

//	void OnTriggerEnter(Collider other){
//		if (Time.time >= timeLeft - 5) {
//		timeLeft = Time.time;
//
//			Debug.Log ("counting");
//		}
//
//	}
}
