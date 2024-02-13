using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DatosJugador : MonoBehaviour

{
    public int vidaPlayer;
    public Slider vidaVisual;
       
       void Update()
    {

       

        if (vidaVisual != null) // Verificar si la referencia a vidaVisual no es nula
        {
            vidaVisual.value = vidaPlayer; // Actualizar el valor del slider con la vida del jugador
        }
       

        if (vidaPlayer <= 0)
        {
            Debug.Log("Game over");
            // Aquí puedes agregar lógica adicional para manejar el fin del juego
        }
    }
}
