using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutFruit : MonoBehaviour {

	void OnMouseDown() {
		//if (collision.gameObject.tag == "Cut") {
			Destroy (this.gameObject);
			GameObject scoreText = GameObject.Find ("ScoreText");
			scoreText.GetComponent<ShowScore> ().incrementScore (1);
		//}
	}
}
