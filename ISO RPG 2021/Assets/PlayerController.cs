using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 4.5f;
    Vector3 velocity;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight = 0.0001f;
    bool grounded;
    public Animator anim;



    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        
        grounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        if(move!=Vector3.zero)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
        move = Quaternion.Euler(30, 45, 0) * move;
        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        
        controller.Move(velocity * Time.deltaTime);

        /*
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isMoving", true);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isMoving", true);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isMoving", true);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isMoving", true);
        }

        else
        {
            anim.SetBool("isMoving", false);
        }
        */

    }
}
