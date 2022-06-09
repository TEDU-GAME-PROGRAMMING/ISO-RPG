using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonHealth : MonoBehaviour
{
    public int maxHealth = 150;
    public int currentHealth;

    public GameObject enemy;
    public PlayerHealth ph;
    public EnemyHealthBar healthBar;

    private bool isDead = false;
    public Animator anim;
    public Animator heroAnim;
    public float dis;
    public Transform other;
    public bool attacked = false;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }



    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.X))  //Testing purposes
        {
            TakeDamage(20);
        }*/
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            ph.TakeDamage(3);
        }
        dis = Vector3.Distance(other.position, transform.position);
        if (dis < 2.5 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            TakeDamage(15);
        }
        if (dis < 2.5 && anim.GetCurrentAnimatorStateInfo(0).IsName("Attack") && !attacked)
        {
            ph.TakeDamage(1);
            attacked = true;
        }
        else
        {
            attacked = false;
        }
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        //anim.Play("Damage1", 0);

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

        Destroy(enemy, 2f);
        SceneManager.LoadScene("Ending");
    }



}