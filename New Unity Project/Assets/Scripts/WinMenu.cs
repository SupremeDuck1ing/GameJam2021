using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinMenu : MonoBehaviour
{
    
    public string mainMenu; 

    public void Main()
    { 
        SceneManager.LoadScene(mainMenu);
    }

    public void Exit()
    { 
        Application.Quit();
    }
}
