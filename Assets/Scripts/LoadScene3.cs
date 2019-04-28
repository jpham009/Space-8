using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene3 : MonoBehaviour
{
    public Collider2D col; 

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            //int level_Score = PlayerPrefs.GetInt("CurrentScore") + (int)Score.scoreValue;
            int level_Score = (int)Score.scoreValue;
            PlayerPrefs.SetInt("CurrentScore", level_Score);
            PlayerPrefs.SetInt("LevelReached", 3);
            //SceneManager.LoadScene("Score_Scene", LoadSceneMode.Single);
            SceneManager.LoadScene("Jess_Scene", LoadSceneMode.Single);
        }
    }

}
