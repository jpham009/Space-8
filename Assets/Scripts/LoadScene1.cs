using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene1 : MonoBehaviour
{
    public void Load1()
    {
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene("Johnny_Scene", LoadSceneMode.Single);
        PlayerPrefs.SetInt("LevelReached", 1);
    }
}