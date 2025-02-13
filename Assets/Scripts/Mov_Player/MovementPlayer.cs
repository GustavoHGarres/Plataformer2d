using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{

    private float horizontalInput;
    private Rigidbody2D rb;
    public int speed = 5;
    public int forceJump = 600; 

    public Transform footPlayer;
    public LayerMask floorLayer;

    private bool thisFloor;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && thisFloor)
        {
           rb.AddForce(Vector2.up * forceJump);
        }

        thisFloor = Physics2D.OverlapCircle(footPlayer.position, 0.2f, floorLayer); // Quais objetos colidam em volta do circulo que surge neste ponto.
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (horizontalInput * speed, rb.velocity.y);
    }
}
