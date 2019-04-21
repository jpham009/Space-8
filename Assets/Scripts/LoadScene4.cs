using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene4 : MonoBehaviour
{
    public Collider2D col;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            SceneManager.LoadScene("Linda_Scene", LoadSceneMode.Single);
        }
    }

}
