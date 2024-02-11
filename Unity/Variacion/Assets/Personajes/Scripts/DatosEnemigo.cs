using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DatosEnemigo : MonoBehaviour

{
    public int vidaEnemigo;
    public Slider vidaVisual;
       
        private void Update()
        {


        vidaVisual.GetComponent<Slider>().value = vidaEnemigo;
           if(vidaEnemigo <=0)
           {
            Debug.Log("Enemigo eliminado");
        
           } 
        }
}