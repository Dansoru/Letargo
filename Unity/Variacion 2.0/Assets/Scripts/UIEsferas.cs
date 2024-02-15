using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIEsferas : MonoBehaviour
{
    public GameObject CanvasEscogerPersonaje, PosInicial;

    public void CambiarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo");
    }


    public void EscogerPersonaje(GameObject gameObject)
    {
        CanvasEscogerPersonaje.SetActive(false);
        GameObject Personaje = Instantiate(gameObject);
        Camera.main.gameObject.SetActive(false);
        Personaje.transform.position = PosInicial.transform.position;
    }
}
