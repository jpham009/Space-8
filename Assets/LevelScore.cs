using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScore : MonoBehaviour
{
    public Text currentScoreText;
    // Start is called before the first frame update
    void Start()
    {
        int lvlScore = PlayerPrefs.GetInt("Score");
    
        currentScoreText.text = lvlScore.ToString();
       
    }

}
