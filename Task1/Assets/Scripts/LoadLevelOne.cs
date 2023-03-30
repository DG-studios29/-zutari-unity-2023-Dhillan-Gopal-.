using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadLevelOne : MonoBehaviour
{
    // call next scene
    public void loadLevel()
    {
        SceneManager.LoadScene("LevelOne");
    }
}
