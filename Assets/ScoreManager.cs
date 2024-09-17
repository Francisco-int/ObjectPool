using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score = 0;

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString("F6");
        score = Time.time;
    }
}

