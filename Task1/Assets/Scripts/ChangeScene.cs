using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    // call next scene
    public void backToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    // call weather app
    public void weatherApp()
    {
        SceneManager.LoadScene("WeatherApp");
    }
}
