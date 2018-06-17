﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour {

    public Text scoreText;
    public Text highScoreText;
    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMenu(int score, int highScore)
    {
        gameObject.SetActive(true);
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
    }
}
