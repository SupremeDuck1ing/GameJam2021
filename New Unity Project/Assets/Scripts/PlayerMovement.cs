using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public CharacterController2D controller; 
    public Animator animator;

    public float runSpeed = 40f;

    float leftRight = 0f; 
    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        leftRight = Input.GetAxisRaw("Horizontal") * runSpeed;  

        animator.SetFloat("Speed", Mathf.Abs(leftRight));

        if(Input.GetButtonDown("Jump"))
        { 
            jump = true; 
            animator.SetBool("Jumping", true);

        } 

        if(Input.GetButtonDown("Crouch"))
        { 
            crouch = true;

        } 
        else if (Input.GetButtonUp("Crouch")) 
        { 
            crouch = false;
        }
    }  

    public void onLanding()
    { 
        animator.SetBool("Jumping", false);
    }

    void FixedUpdate()
    { 
        //Character Movement
        controller.Move(leftRight * Time.fixedDeltaTime, crouch, jump); 
        jump = false;
    }
}
