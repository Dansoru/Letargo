using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosJugador : MonoBehaviour

{
    public int vidaPlayer;

       
        private void Update()
        {
           if(vidaPlayer <=0)
           {
            Debug.Log("Game over");
        
           } 
        }
}