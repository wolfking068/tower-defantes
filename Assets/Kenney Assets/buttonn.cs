using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonn : MonoBehaviour {
    public void retry()
    {
        SceneManager.LoadScene(1);
    }
    public void stopgame()
    {
        Application.Quit();
    }
}
