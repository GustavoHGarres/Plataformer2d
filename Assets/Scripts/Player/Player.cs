using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

public Rigidbody2D myRigidbody;
public Vector2 friction = new Vector2(.1f, 0);
//public float speed;
//public float speedRun;
//public float forceJump; 
private float _currentSpeed;

public SOFloat sospeed;
public SOFloat sospeedRun;
public SOFloat soforceJump;

[Header("Animation Player")]
public string boolRun = "Run";
public string boolRunSpeed = "RunSpeed";
public string boolAttack = "Attack";
public string boolKick = "Kick";
public string boolJump = "Jump";
public string boolSpecial = "Special";

public Animator animator;

[Header("Particles")]

public ParticleSystem particleDust;

private void Update()
{
HandleJump();
HandleBoolJump();
HandleMoviment();
HandleAttack();
HandleKick();
HandleSpecial();
}

private void HandleMoviment()
{

      if (Input.GetKey(KeyCode.LeftControl))
       _currentSpeed = sospeedRun.value;
        else
       _currentSpeed = sospeed.value;

//==========================================================================================       

        if (Input.GetKey(KeyCode.LeftControl))
           {
            animator.SetBool(boolRunSpeed, true);
           }
       
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
      myRigidbody.velocity = Vector2.up * soforceJump.value;
      ParticlesDust();
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

private void HandleSpecial()
{
      if (Input.GetKeyDown(KeyCode.D))
           {
            animator.SetBool(boolSpecial, true);
           }
 
      else
        {
             animator.SetBool(boolSpecial, false);
        }   
}

private void ParticlesDust()
    {
        if(particleDust != null) particleDust.Play();
    }

}
