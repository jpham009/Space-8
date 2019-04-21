using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        int highScore;
        int Scorelvl = PlayerPrefs.GetInt("Score");
        string str = PlayerPrefs.GetString("highScore", null);
        if (string.IsNullOrEmpty(str) == true)
        {
            highScore = Scorelvl;
        }
        else
        {
            highScore = PlayerPrefs.GetInt("highScore");
        }
        if (highScore < Scorelvl)
        {
            highScore = Scorelvl;
            PlayerPrefs.SetInt("highScore", highScore);
            highScoreText.text = highScore.ToString();
        }

    }

}

