using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public static int vidas = 3;
    public int vidaPublic;
    public bool puedeHacerDano = true;
    public Corazones corazonesScript; // Variable para almacenar una referencia al script Corazones

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaPublic = vidas;
    }

    public void OnTriggerEnter(Collider col)
    {
        if (!puedeHacerDano)
            return;

        if (col.CompareTag("Enemigo"))
        {
            puedeHacerDano = false;
            Invoke("ActivarDaño", 1);
            vidas -= 1;

            if (corazonesScript != null) // Verificar si la referencia a Corazones es válida
            {
                corazonesScript.reducirCorazon(); // Llamar al método reducirCorazon del script Corazones
            }
            if (vidas <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    void ActivarDaño()
    {
        puedeHacerDano = true;
    }
}