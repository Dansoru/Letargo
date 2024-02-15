using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{

    public WeaponManager weaponManager;
    public List<GameObject> gameObjects = new List<GameObject>();
    

    public void CambiarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo");
    }

    public void SeleccionPersonajeVida(int vida)
    {
        
        Personaje.vidas = vida;
    }

    public void SeleccionPersonajeDaño(int daño)
    {
        foreach (var item in gameObjects)
        {
            item.SetActive(true);
        }
        weaponManager.damage = daño;

    }
}
