using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathMenu : MonoBehaviour
{
    public string currLevel;

    public string mainMenu; 


    public void restartLvl()
    { 
        SceneManager.LoadScene(currLevel);
    }

    public void Main()
    { 
        SceneManager.LoadScene(mainMenu);
    }

    public void Exit()
    { 
        Application.Quit();
    }
}
