using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScores : MonoBehaviour
{


    //void Start()
    //{

    //}

    public void loadScores()
    {


        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Score_Scene", LoadSceneMode.Single);

    }
}