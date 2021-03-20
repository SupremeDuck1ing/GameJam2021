using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerSpritesv2 : MonoBehaviour
{

    public SpriteRenderer correctSprite; 
    public SpriteRenderer wrongSprite1;
    public SpriteRenderer wrongSprite2;
    public SpriteRenderer secondNumber; 
    public SpriteRenderer totalSprite;
    public Sprite[] spriteArray;  

    public GameObject rightAnswer; 
    public GameObject wrong1; 
    public GameObject wrong2; 
    public GameObject number2; 
    public GameObject totalObject;
    

    
   
    // Start is called before the first frame update
    void Start()
    {  
        rightAnswer = GameObject.Find("CorrectAnswer_2"); 
        wrong1 = GameObject.Find("IncorrectAnswer1_2");
        wrong2 = GameObject.Find("IncorrectAnswer2_2");
        number2 = GameObject.Find("EqPt2_2");
        totalObject = GameObject.Find("Total_2");


        correctSprite = rightAnswer.GetComponent<SpriteRenderer>();  
        wrongSprite1 = wrong1.GetComponent<SpriteRenderer>();
        wrongSprite2 = wrong2.GetComponent<SpriteRenderer>();
        secondNumber = number2.GetComponent<SpriteRenderer>(); 
        totalSprite = totalObject.GetComponent<SpriteRenderer>();
        
        int int1 = Random.Range(0, 5);  
        //Debug.Log(int1);
        int int2 = Random.Range(0, 4);   
        //Debug.Log(int2);
        int total = int1+int2;   
        Debug.Log("Total=");
        Debug.Log(total);

        correctSprite.sprite = spriteArray[int1];
        secondNumber.sprite = spriteArray[int2]; 
        totalSprite.sprite = spriteArray[total];
        
        int incorrect1 = 0; 
        int incorrect2 = 0;
 

        incorrect1 = Random.Range(0, 5); 
        incorrect1 = Random.Range(0, 5);
        
        while (incorrect1 == int1) 
        { 
            incorrect1 = Random.Range(0, 5);
        } 

        while (incorrect2 == int1 || incorrect2 == incorrect1) 
        { 
            incorrect2 = Random.Range(0, 5);
        }

        wrongSprite1.sprite = spriteArray[incorrect1];
        wrongSprite2.sprite = spriteArray[incorrect2];








        
    }
    
        



    
}
