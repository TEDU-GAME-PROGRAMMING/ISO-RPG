using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 100;
    public int currentHealth;
    
    public GameObject enemy;
    public EnemyHealthBar healthBar;

    private bool isDead = false;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))  //Testing purposes
        {
            TakeDamage(20);
        }
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        anim.Play("Damage1", 0);

        if (currentHealth <= 0 && !isDead)
        {
            //anim.Play("Damage2", 0);

            //WaitForSeconds(2);

            Die();
        }

    }
    void Die()
    {
        isDead = true;

        Destroy(enemy); 
    }



}
