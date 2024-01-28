using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Referencia al componente de animaci�n
    private Animator animator;

    void Start()
    {
        // Obtener el componente Animator adjunto al mismo GameObject
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            // Verificar si la tecla "B" est� siendo presionada
            Debug.Log("Se presion� la tecla 'b'");

            // Ejecutar la animaci�n "Rumba Dancing"
            animator.SetTrigger("RumbaDancingTrigger");
        }

      
        if (Input.GetMouseButtonDown(0)) // 0 representa el bot�n izquierdo del rat�n
        {
            // Verificar si se presion� click izquierdo
            Debug.Log("Se presion� click izquierdo");

            // Ejecutar la animaci�n "punching"
            animator.SetTrigger("PunchingTrigger");
        }
    }
}


