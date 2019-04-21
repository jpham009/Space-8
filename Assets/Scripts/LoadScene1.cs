using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene1 : MonoBehaviour
{
    public void Load1()
    {
        
        SceneManager.LoadScene("Johnny_Scene", LoadSceneMode.Single);
      
    }
}