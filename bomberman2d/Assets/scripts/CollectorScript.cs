using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectorScript : MonoBehaviour {

	public Text scoreText;
	private int score = 0;

	void Start () {
		Debug.Log("start game");
	}
	void IncreaseScore() {
		score++;

		scoreText.text = "Score: " + score;

	}

	void OnTriggerEnter2D(Collider2D target) {
		Debug.Log("Text: " +target.tag);
		if (target.tag == "Bomb") {

			// IncreaseScore ();
			target.gameObject.SetActive (false);
		}
	}

}
