using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelSelect : MonoBehaviour
{

    public string lvl1;

    public string lvl2; 

    public string main;


    public void Level1()
    { 
        SceneManager.LoadScene(lvl1);
    }

    public void Level2()
    { 
        SceneManager.LoadScene(lvl2);
    }

    public void Main()
    { 
        SceneManager.LoadScene(main);    
        }
}
