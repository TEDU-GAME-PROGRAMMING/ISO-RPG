using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;
    public Animator anim;
    public PlayerHealth health;
    

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if(distance <= lookRadius&& distance>2f )
        {
            anim.SetBool("inCombat", false);
            anim.SetBool("hunting", true);
            agent.SetDestination(target.position);
            
        }
        else if(distance<=2f)
        {
            anim.SetBool("hunting",false);
            anim.SetBool("inCombat", true);
            damagePlayer(1);

        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
        
    }

    void damagePlayer(int damage)
    {
        health.TakeDamage(damage);
    }

}
