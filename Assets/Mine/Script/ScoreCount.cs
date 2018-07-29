using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour {

    static public int score;
    public GUIText ScoreText;

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        ScoreText.text = ("Score : " + score);
	}
}
