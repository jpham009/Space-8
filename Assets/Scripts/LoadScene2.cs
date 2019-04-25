using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene2 : MonoBehaviour
{
    public Collider2D col;



    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerPrefs.SetInt("Score",(int)Score.scoreValue);
        PlayerPrefs.SetInt("LevelReached",2);
        if (col.tag == "Player")
        SceneManager.LoadScene("Edgar_Scene", LoadSceneMode.Single);
    }

}
