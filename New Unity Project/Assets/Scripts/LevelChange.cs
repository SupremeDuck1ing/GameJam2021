using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{ 

    public LevelManager levelManager;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.name == "Player")
        {  
            Debug.Log("Load Scene"); 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
