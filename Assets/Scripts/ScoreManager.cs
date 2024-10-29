using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;

    public Text scoreText;
    int score = 0;

    void Start()
    {
        scoreManager = this;
    }

    public void RaiseScore(int num)
    {
        score += num;
        scoreText.text = score.ToString();
    }

}
