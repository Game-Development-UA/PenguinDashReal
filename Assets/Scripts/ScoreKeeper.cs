using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
	public TextMeshProUGUI label;
	float score;

	public MovePenguin player;

	void FixedUpdate() {
		score += player.body.velocity.z;

		label.text = ((int)score).ToString();
	}

	// public void UpdateScore() {
	// 	score = newScore;
		
	// }
}
