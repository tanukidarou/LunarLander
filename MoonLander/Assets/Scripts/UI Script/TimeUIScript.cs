﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUIScript : MonoBehaviour {

	Text timerTextUI;

	float timer;
	float seg, min = 0;

	string sMin, sSeg, addMin, addSeg;

	// Use this for initialization
	void Awake () {
		timerTextUI = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer = Time.time;
		seg = (int)timer % 60;
		min = (int)timer / 60;

		sMin = min.ToString ();
		sSeg = seg.ToString ();

		if (seg < 10)
			sSeg = "0" + sSeg;

		if (min < 10)
			sMin = "0" + sMin;

		timerTextUI.text = "'" + sMin + "  ''" + sSeg;
	}
}
