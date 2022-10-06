using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    private int initialScore = 0;
    
    public void changeScore(int score)
    {
        initialScore += score;
        scoreUI.text = "Score: " + initialScore;
    }
}
