using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JugadorDaño : MonoBehaviour
{
    public int damage;
    //public GameObject enemigo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            DatosEnemigo datosEnemigo = other.GetComponent<DatosEnemigo>();
            if (datosEnemigo != null)
            {
                datosEnemigo.vidaEnemigo -= damage;
            }
        }

       /* if (other.CompareTag("Player"))
        {
            Debug.Log("Esto es un jugador");
        }*/
    }
}