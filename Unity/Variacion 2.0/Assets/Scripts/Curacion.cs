using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curacion : MonoBehaviour
{
    public Personaje personaje;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(Personaje.vidas < personaje.vidasOriginales)
            {
                Debug.Log("Se curo al jugador");
                Personaje.vidas++;
                personaje.ActualizarUIVidas();
            }
            
            
        }
    }
}
