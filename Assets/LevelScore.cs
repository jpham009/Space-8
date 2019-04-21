using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScore : MonoBehaviour
{
    public Text currentScoreText;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        int highScore;
        int lvlScore = PlayerPrefs.GetInt("Score");
        string str = PlayerPrefs.GetString("highScore", null);
        if (string.IsNullOrEmpty(str) == true) {
            highScore = lvlScore;
        }
        else
        {
            highScore = PlayerPrefs.GetInt("highScore");
        }
        if (highScore < lvlScore) {
            highScore = lvlScore;
            PlayerPrefs.SetInt("highScore",highScore);
            highScoreText.text = highScore.ToString();
        }

        currentScoreText.text = lvlScore.ToString();
       
    }

}
