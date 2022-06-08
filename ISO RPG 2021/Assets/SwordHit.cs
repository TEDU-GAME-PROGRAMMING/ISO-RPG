using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHit : MonoBehaviour
    
{
    EnemyHealth eh;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.gameObject.tag=="Sword")
        {
            eh.currentHealth -= 25;
        }
    }
}
