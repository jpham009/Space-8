using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene1 : MonoBehaviour
{
    

    //void Start()
    //{

    //}

    public void Load1()
    {
        
       
            // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
            SceneManager.LoadScene("Scene 1", LoadSceneMode.Single);
      
    }
}