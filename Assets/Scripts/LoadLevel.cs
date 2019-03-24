using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{

    public GameObject TransitionLevel;
    public string levelToLoad;

    void Start()
    {
        TransitionLevel.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            TransitionLevel.SetActive(true);
            if (TransitionLevel.activeInHierarchy==true)
            {
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }
    void OnTriggerExit(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            TransitionLevel.SetActive(false);
        }
    }
}