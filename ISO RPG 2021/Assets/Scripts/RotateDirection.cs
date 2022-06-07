using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDirection : MonoBehaviour
{
    bool aW = false;
    bool aS = false;
    bool dW = false;
    bool ds = false;

    public void Update()
    {
        if(Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.W))
        {
            aW = true;
        }
        if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            aS = true;
        }
        if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            dW = true;
        }
        if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            ds = true;
        }
        if(aW)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            aW = false;
        }
        if(aS)
        {
            transform.eulerAngles = new Vector3(0, -90, 0);
            aS = false;
        }
        if(dW)
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
            dW = false;
        }
        if(ds)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            ds = false;
        }
           
        if(!(dW||ds||aW||aS))
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.eulerAngles = new Vector3(0, 225, 0);

            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.eulerAngles = new Vector3(0, 45, 0);

            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.eulerAngles = new Vector3(0, -45, 0);

            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0, 135, 0);

            }
        }
    }

}
