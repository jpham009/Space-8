using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEnding : MonoBehaviour
{
    public Collider2D col; 

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            //int level_Score = PlayerPrefs.GetInt("Score") + (int)Score.scoreValue;
            int level_Score = (int)Score.scoreValue;
            PlayerPrefs.SetInt("CurrentScore", level_Score);
            PlayerPrefs.SetInt("LevelReached", 5);
            SceneManager.LoadScene("Home Screen", LoadSceneMode.Single);
        }
    }
}
