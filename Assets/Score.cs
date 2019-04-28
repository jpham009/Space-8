using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static double scoreValue;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        //scoreValue = 0;
        scoreValue = (double)PlayerPrefs.GetInt("CurrentScore");
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreValue <= 0){
            scoreValue = 0;
        }
        //scoreValue = (scoreValue + .05);
        score.text = "Score: " + scoreValue.ToString("0");
    }
}
