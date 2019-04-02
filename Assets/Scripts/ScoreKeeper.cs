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
		if(!player.dead){
			score += player.body.velocity.z;
			label.text = ((int)score).ToString();
		}
	}
}
