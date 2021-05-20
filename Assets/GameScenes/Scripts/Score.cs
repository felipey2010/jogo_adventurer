﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    Player player;

    public int score;
    public Text scoreDisplay;

    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(player.health > 0)
        {
            score++;
        }
   
        Destroy(other.gameObject);
    }
}
