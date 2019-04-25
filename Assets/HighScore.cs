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
        int Scorelvl = PlayerPrefs.GetInt("CurrentScore");
        int highScore = PlayerPrefs.GetInt("highScore", 0);
     
        if (highScore < Scorelvl)
        {
            highScore = Scorelvl;
        }
        PlayerPrefs.SetInt("highScore", highScore);
        highScoreText.text = highScore.ToString();
    }

}

