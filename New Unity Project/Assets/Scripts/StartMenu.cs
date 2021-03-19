using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartMenu : MonoBehaviour
{
    public string startLevel;

    public string levelSelected; 


    public void newGame()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void levelSelect()
    { 
        SceneManager.LoadScene(levelSelected);
    }

    public void Exit()
    { 
        Application.Quit();
    }

}
