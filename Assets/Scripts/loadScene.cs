using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public void StartScene() 
    {
        SceneManager.LoadScene(0);

    }
    public void LogInScene()
    {
        SceneManager.LoadScene(1);

    }
    public void CreateAccountScene()
    {
        SceneManager.LoadScene(2);

    }
    public void CustomizeAvatartScene()
    {
        SceneManager.LoadScene(3);

    }
    public void HomeScene()
    {
        SceneManager.LoadScene(4);

    }
    public void StepCounterScene()
    {
        SceneManager.LoadScene(5);

    }
}
