using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    RagdollManager ragdollManager;
    [HideInInspector] public bool isDead;
    public GameObject Player;
    Vector3 PosInicial;
    public ContadorEnemigos contadorEnemigos;

    private void Start()
    {
        ragdollManager = GetComponent<RagdollManager>();
        PosInicial = transform.position;
    }

    private void Update()
    {
        NavMeshAgent navMeshAgent = GetComponent<NavMeshAgent>();
        if(Player != null)
        {
            navMeshAgent.SetDestination(Player.transform.position);
        }
   
        if(Personaje.vidas == 0)
        {
            navMeshAgent.SetDestination(PosInicial);
        }
    }

    public void TakeDamage(float damage)
    {
        if (health > 0)
        {
            health -= damage;
            if (health <= 0) EnemyDeath();
            else Debug.Log("Hit");
        }
    }

    void EnemyDeath()
    {
        GetComponent<SphereCollider>().enabled = false;
        NavMeshAgent navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.isStopped = true;
        contadorEnemigos.contadorEnemigos--;
        contadorEnemigos.UpdateUI();
        ragdollManager.TriggerRagdoll();
        Debug.Log("Death");
    }
}
