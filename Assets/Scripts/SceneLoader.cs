using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private float timer = 0f;
    private bool sceneLoaded = false;
    
    void Update()
    {
        if (!sceneLoaded)
        {
            timer += Time.deltaTime;

            if (timer >= 15f)
            {
                LoadScene();
                sceneLoaded = true;
            }
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene("Main Menu");
    }
}