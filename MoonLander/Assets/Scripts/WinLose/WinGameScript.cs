﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinGameScript : MonoBehaviour {

	float timer = 0;

	int score;
	int bestScore;
	string bestScoreYou;

	Text scoreText;
	Text bestScoreText;

	void Awake () {
		scoreText = transform.FindChild ("ScoreText").GetComponent<Text> ();
		bestScoreText= transform.FindChild ("BestScoreText").GetComponent<Text> ();

		score = PlayerPrefs.GetInt ("Score", 0);
		bestScore = PlayerPrefs.GetInt ("BestScore", 0);

		if (bestScore == score )
			bestScoreYou = " (You)";
		else
			bestScoreYou = "";

		scoreText.text = "You Score - " + ConvertScore (score);
		bestScoreText.text = "Best Score - " + ConvertScore (bestScore) + bestScoreYou;
	}

	void Update () {
		timer += Time.deltaTime;

		if (timer > 4.0f)
			SceneManager.LoadScene ("MainMenu");
		
	}

	string ConvertScore(int scoreToConvert){
		if (scoreToConvert == 0)
			return "00000000";
		if (scoreToConvert < 10)
			return "0000000" + score.ToString();
		else if (scoreToConvert < 100)
			return "000000" + score.ToString();
		else if (scoreToConvert < 1000)
			return "00000" + score.ToString();
		else if (scoreToConvert < 10000)
			return "0000" + score.ToString();
		else if (scoreToConvert < 100000)
			return "000" + score.ToString();
		else if (scoreToConvert < 1000000)
			return "00" + score.ToString();
		else if (scoreToConvert < 10000000)
			return "0" + score.ToString();
		else if (scoreToConvert < 100000000)
			return score.ToString();
		else
			return "99999999";
	}
}