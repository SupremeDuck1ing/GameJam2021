using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerSprites : MonoBehaviour
{

    public SpriteRenderer correctSprite; 
    public Sprite[] spriteArray; 
    // Start is called before the first frame update
    void Start()
    {
        correctSprite = gameObject.GetComponent<SpriteRenderer>();  
        int int1 = Random.Range(0, 5); 
        int int2 = Random.Range(0, 4);   
        int total = int1+int2; 
        /*Debug.Log(int1); 
        Debug.Log("+"); 
        Debug.Log(int2);  
        Debug.Log("="); 
        Debug.Log(total); */ 


        correctSprite.sprite = spriteArray[int2];








        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
