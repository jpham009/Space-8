using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSettings : MonoBehaviour
{


    //void Start()
    //{

    //}

    public void loadSettings()
    {


        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);

    }
}