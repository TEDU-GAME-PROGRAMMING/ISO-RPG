using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 100;
    public int health;
    
    public GameObject skeleton;
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
       if(health<=0)
        {
            Destroy(skeleton);
        }
        
        
    }
       
    
}
