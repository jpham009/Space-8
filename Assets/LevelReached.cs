using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelReached : MonoBehaviour
{
    public Text levelReachedText;
    // Start is called before the first frame update
    void Start()
    {
        int levelIndex = PlayerPrefs.GetInt("LevelReached");
        
            levelReachedText.text = levelIndex.ToString();
        

    }

}

