using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyManager : MonoBehaviour
{
    public Slider Difficulty;

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("Difficulty", Difficulty.value);
    }
}
