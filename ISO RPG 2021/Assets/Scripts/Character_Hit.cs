using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Hit : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerHealth ph;
    
     void OnCollisionEnter(UnityEngine.Collision collision)
    {
        
        
            
            collision.gameObject.SendMessage("TakeDamage", 50);
            ph.TakeDamage(1);
        
    }
}
