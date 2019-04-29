using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene2 : MonoBehaviour
{
    public Collider2D col;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            //int level_Score = PlayerPrefs.GetInt("CurrentScore") + (int)Score.scoreValue;
            int level_Score = (int)Score.scoreValue;

            PlayerPrefs.SetInt("CurrentScore", level_Score);
            PlayerPrefs.SetInt("LevelReached", 2);

            //SceneManager.LoadScene("Score_Scene", LoadSceneMode.Single);
            SceneManager.LoadScene("Edgar_Scene", LoadSceneMode.Single);
        }
    }

}
