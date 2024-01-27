using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Referencia al componente de animación
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
            // Verificar si la tecla "B" está siendo presionada
            Debug.Log("Se presionó la tecla 'b'");

            // Ejecutar la animación "Rumba Dancing"
            animator.SetTrigger("RumbaDancingTrigger");
        }
    }
}
