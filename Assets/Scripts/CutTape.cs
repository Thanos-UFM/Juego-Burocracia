﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTape : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cut") {
			Destroy (this.gameObject);
			GameObject scoreText = GameObject.Find ("ScoreText");
			scoreText.GetComponent<ShowScore> ().incrementScore (1);
		}
	}
}
