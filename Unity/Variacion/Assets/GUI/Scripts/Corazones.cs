using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Corazones : MonoBehaviour
{
    public Sprite[] CorazonesArray;
    public Queue<Sprite> CorazonesCola = new Queue<Sprite>();
    public static Corazones instancia;

    void Start()
    {
        instancia = this;
        foreach (Sprite sprite in CorazonesArray)
        {
            CorazonesCola.Enqueue(sprite);
        }

        // Aquí asumo que cada sprite está asociado a una imagen en la escena
        // y se deben desactivar al inicio.
        foreach (var imagen in GetComponentsInChildren<Image>())
        {
            imagen.gameObject.SetActive(false);
        }
    }

    public void reducirCorazon()
    {
        Debug.Log("quitar corazon");

        if (CorazonesCola.Count > 0)
        {
            Sprite sprite = CorazonesCola.Dequeue();
            
            // Aquí activamos la imagen asociada al sprite
            foreach (var imagen in GetComponentsInChildren<Image>())
            {
                if (imagen.sprite == sprite)
                {
                    imagen.gameObject.SetActive(false);
                    break;
                }
            }
        }
    }
}