using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 6f;

    public float turnSmoothTime = 0.1f;

    float turnSmoothVelocity;

    public Animator anim;


    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f)
;
            controller.Move(direction * speed * Time.deltaTime);
        }

        if (direction != Vector3.zero)
        {
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }

        if(Input.GetKey(KeyCode.Mouse0) && !(anim.GetBool("Walking")))
        {
            int rando = Random.Range(1, 4);
            if(rando <=1.5)
            {
                anim.Play("Female Sword Attack 1", 0);
                
            }
            else if(rando <=2.5)
            {
                anim.Play("Female Sword Attack 2", 0);
            }
            else
            {
                anim.Play("Female Sword Attack 3", 0);
            }
        }
            
        }
        
    }

