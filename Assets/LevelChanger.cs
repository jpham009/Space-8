using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    private int levelToLoad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            FadeToLevel(1);
        }
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex; 
        animator.SetTrigger("fadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
