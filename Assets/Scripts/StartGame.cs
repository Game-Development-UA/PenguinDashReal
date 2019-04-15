using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class StartGame : MonoBehaviour
{
	public MovePenguin player;
	public GameObject startUI;
	public TextMeshProUGUI label;
	public TextMeshProUGUI score;
	public GameObject highscore;
	public GameObject highscoreLabel;


	public void Begin() {
		highscoreLabel.SetActive(false);
		highscore.SetActive(false);
		player.body.isKinematic = false;
		GameObject.Find("TitleText").SetActive(false);
		Destroy( startUI );
		score.text = "0";
		label.text = "Score: ";
		player.started = true;
	}
}
