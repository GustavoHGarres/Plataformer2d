using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

public Rigidbody2D myRigidbody;
public Vector2 friction = new Vector2(.1f, 0);
public float speed;
public float speedRun;
public float forceJump; 
public float _currentSpeed;

[Header("Animation Player")]
public string boolRun = "Run";
public string boolRunSpeed = "RunSpeed";
public string boolAttack = "Attack";
public string boolKick = "Kick";

public string boolJump = "Jump";

public Animator animator;

private void Update()
{
HandleJump();
HandleBoolJump();
HandleMoviment();
HandleAttack();
HandleKick();
}

private void HandleMoviment()
{

      if (Input.GetKey(KeyCode.LeftControl))
       _currentSpeed = speedRun;
        else
       _currentSpeed = speed;

//======================================================       

        if (Input.GetKey(KeyCode.LeftControl))
           {
            animator.SetBool(boolRunSpeed, true);
           }

       // else if (Input.GetKey(KeyCode.LeftControl))  

       // {
           // animator.SetBool(boolRunSpeed, true);
       // } 

        else
        {
             animator.SetBool(boolRunSpeed, false);
        }    
   
//=========================================================================================

         if (Input.GetKey(KeyCode.LeftArrow))
         {
               myRigidbody.velocity = new Vector2(-_currentSpeed, myRigidbody.velocity.y);
               myRigidbody.transform.localScale = new Vector3(-1,1,1);
               animator.SetBool(boolRun, true);
         }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
              myRigidbody.velocity = new Vector2(_currentSpeed, myRigidbody.velocity.y);
               myRigidbody.transform.localScale = new Vector3(1,1,1);
              animator.SetBool(boolRun, true);
        }

        else
        {
             animator.SetBool(boolRun, false);
        }

//=============================================================================================



        if (myRigidbody.velocity.x > 0)
        {
             myRigidbody.velocity += friction;
        }                                                


        else if (myRigidbody.velocity.x < 0)
        {
               myRigidbody.velocity -= friction;
         }
}

private void HandleJump()
{
     if (Input.GetKeyDown(KeyCode.Space))
     {
      myRigidbody.velocity = Vector2.up * forceJump;
     }

}

private void HandleBoolJump()
{
      if (Input.GetKeyDown(KeyCode.Space))
           {
            animator.SetBool(boolJump, true);
           }
 
      else
        {
             animator.SetBool(boolJump, false);
        }   
}


private void HandleAttack()
{
      if (Input.GetKeyDown(KeyCode.A))
           {
            animator.SetBool(boolAttack, true);
           }
 
      else
        {
             animator.SetBool(boolAttack, false);
        }   
}

private void HandleKick()
{
      if (Input.GetKeyDown(KeyCode.S))
           {
            animator.SetBool(boolKick, true);
           }
 
      else
        {
             animator.SetBool(boolKick, false);
        }   
}

}
