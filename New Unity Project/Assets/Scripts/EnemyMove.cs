using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{ 

    public Rigidbody2D enemyBody; 
    public int moveUnits = 1; 
    public float enemySpeed = 200; 
    public bool facingRight;
    private float start;
    private float end; 

    public bool moveRight = true;
    // Start is called before the first frame update
    void Start()
    {
        enemyBody = GetComponent<Rigidbody2D>(); 
        start = transform.position.x; 
        end = start + moveUnits; 
        facingRight = transform.localScale.x > 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveRight)
        { 
            enemyBody.AddForce(Vector2.right * enemySpeed * Time.deltaTime); 
            if(!facingRight)
            { 
                Flip();
            }
        } 

        if(enemyBody.position.x >= end) 
        { 
            moveRight = false;
        } 

        if(!moveRight)
        { 
            enemyBody.AddForce(-Vector2.right * enemySpeed * Time.deltaTime); 
            if(facingRight)
            { 
                Flip();
            }
        }  

        if(enemyBody.position.x <= start) 
        { 
            moveRight = true;
        } 
    } 

    void Flip()
    { 
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
