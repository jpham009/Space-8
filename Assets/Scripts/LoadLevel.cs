using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{

    public GameObject TransitionExit;
    public string levelToLoad;

    void Start()
    {
        TransitionExit.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            TransitionExit.SetActive(true);
            if (TransitionExit.activeInHierarchy == true)
            {
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }
    void OnTriggerExit(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            TransitionExit.SetActive(false);
        }
    }
}