using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosEnemigo : MonoBehaviour

{
    public int vidaEnemigo;
    public Slider vidaVisual;
    public Animator animator;

    private void Start()
    {
        vidaVisual.maxValue = vidaEnemigo;
        animator.GetComponent<Animator>();
    }




    void Update()
    {
        // Verifica si vidaVisual no es nulo antes de intentar acceder a sus componentes
        if (vidaVisual != null)
        {
            // Actualiza el valor del slider con la vida del enemigo
            vidaVisual.value = vidaEnemigo;
        }

        // Verifica si la vida del enemigo es menor o igual a cero
        if (vidaEnemigo <= 0)
        {
            // Si es así, muestra un mensaje de depuración
            animator.Play("Muerte");
            //Debug.Log("Enemigo eliminado");
        }
    }
}

