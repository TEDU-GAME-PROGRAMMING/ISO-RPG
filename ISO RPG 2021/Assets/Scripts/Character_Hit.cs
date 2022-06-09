using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Hit : MonoBehaviour
{
    // Start is called before the first frame update
    
     void OnCollisionEnter(UnityEngine.Collision collision)
    {
        
        
            Debug.Log("Hit!");
            collision.gameObject.SendMessage("TakeDamage", 50);
        
    }
}
