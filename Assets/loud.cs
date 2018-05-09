using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loud : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene(1);  
    }
    public void exit()
    {
        Application.Quit();
    }
}
