using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreeScript : MonoBehaviour
{

    public string level;

    public void RetryLevel()
    {
        SceneManager.LoadScene(level);
    }

    public void ExitGame()
    {
        Application.Quit();
        print("Exit Game");
    }
}
