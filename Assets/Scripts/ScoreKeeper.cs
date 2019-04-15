using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
	public TextMeshProUGUI label;
	float score;
	public MovePenguin player;
	public TextMeshProUGUI highscore;
	public TextMeshProUGUI highscoreLabel;
	bool newHighscore = false;
	bool changedLabel = false;

	void Start () {
		highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
	}

	public void Reset(){
		PlayerPrefs.DeleteAll();
		highscore.text = "0";
	}

	void FixedUpdate() {
		if(!player.dead && player.started){
			score += player.body.velocity.z;
			int number = (int)score;
			label.text = number.ToString();

			if(number > PlayerPrefs.GetInt("HighScore", 0)){
				PlayerPrefs.SetInt("HighScore", number);
				newHighscore = true;
			}

			if(newHighscore && !changedLabel){
				highscoreLabel.text = "New Highscore! :";
				changedLabel = true;
			}
		}
	}
}
