using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DatosJugador : MonoBehaviour

{
    public int vidaPlayer;
    public GameObject[] vidas;
       
    void Update()
    {
        if(vidaPlayer < vidas.Length)
        {
            vidas[vidaPlayer].SetActive(false);
        }
        
        if (vidaPlayer <= 0)
        {
            Debug.Log("Game over");
            // Aquí puedes agregar lógica adicional para manejar el fin del juego
        }
    }

  
}
