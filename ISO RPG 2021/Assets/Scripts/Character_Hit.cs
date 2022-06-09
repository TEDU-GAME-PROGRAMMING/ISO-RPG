using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Hit : MonoBehaviour
{
    // Start is called before the first frame update
    /*private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Hitbox_Enemy")
        {
            other.gameObject.SendMessage("TakeDamage", 50);
        }
    }*/
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Hitbox_Enemy")
        {
            collision.gameObject.SendMessage("TakeDamage", 50);
        }
    }
}
