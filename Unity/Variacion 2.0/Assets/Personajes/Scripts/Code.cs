using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Code : MonoBehaviour
{
    public int rutina;
    public float cronometro;
    public Animator ani;
    public Quaternion angulo;
    public float grado;

    public GameObject target;
    public bool atacando;

    public NavMeshAgent agente;
    public float distancia_ataque;
    public float radio_vision;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        target = GameObject.Find("PlayerArmature");
    }

    void Update()
    {
        Comportamiento_Enemigo();
    }

    public void Comportamiento_Enemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > radio_vision)
        {
            agente.enabled = false;
            ani.SetBool("run", false);
            cronometro += Time.deltaTime;
            if (cronometro >= 4)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
                Debug.Log("Lo detecta");
            }
            switch (rutina)
            {
                case 0:
                    ani.SetBool("walk", false);
                    Debug.Log("Se está enviando false");
                    break;

                case 1:
                    grado = Random.Range(0, 360);
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++;
                    break;

                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                    transform.Translate(Vector3.forward * speed * Time.deltaTime);
                    ani.SetBool("walk", true);
                    break;
            }
        }
        else
        {
            var lookPos = target.transform.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            
            agente.enabled = true;
            agente.SetDestination(target.transform.position);

            if (Vector3.Distance(transform.position, target.transform.position) > distancia_ataque && !atacando)
            {
                ani.SetBool("walk", false);
                ani.SetBool("run", true);
            }
            else
            {
                if (!atacando)
                {
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 1);
                    ani.SetBool("walk", false);
                    ani.SetBool("run", false);
                }
            }
        }
        
        if (atacando)
        {
            agente.enabled = false;
        }
    }

    public void Final_Ani()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > distancia_ataque + 0.2f)
        {
            ani.SetBool("attack", false);
        }
        ani.SetBool("attack", false);
        atacando = false;
        Debug.Log("Está reaccionando");

        Comportamiento_Enemigo();
    }

    public void OnAttackAnimationEnd()
    {
        Final_Ani();
    } 
}