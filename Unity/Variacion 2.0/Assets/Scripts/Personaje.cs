using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations.Rigging;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{
    public static int vidas = 3;
    public int vidasOriginales;
    public int intentos = 3;
    public Slider UIVida;

    public float tiempoSinColision = 1.5f;

    public List<GameObject> enemigos = new List<GameObject>();

    public GameObject CanvasGameOver, CanvasIntentar, UIDaño;

    public TextMeshProUGUI vidasTexto;
    public WeaponManager weaponManager;


    public string layer1Name = "Layer1"; // Name of Layer 1
    public string layer2Name = "Layer2"; // Name of Layer 2


    private int layer1; // Layer 1 ID
    private int layer2; // Layer 2 ID

    private void Start()
    {
        vidasTexto.text = vidas.ToString();
        vidasOriginales = vidas;
        UIVida.maxValue = vidasOriginales;
        layer1 = LayerMask.NameToLayer(layer1Name);
        layer2 = LayerMask.NameToLayer(layer2Name);
        ActualizarUIVidas();
    }

    public void ActualizarUIVidas()
    {
        UIVida.value = vidas;
    }

    public void RecibirDaño()
    {
        vidas--;
        StartCoroutine(PantallaDaño());
        ActualizarUIVidas();

        Debug.Log("Vidas: " + vidas);

        Physics.IgnoreLayerCollision(layer1, layer2, true);
        Invoke("RevertCollision", tiempoSinColision); // Invoke the method to revert collision after duration
        Debug.Log("El jugador no puede chocar con enemigos durante " + tiempoSinColision + " segundos.");
        vidasTexto.text = vidas.ToString();
        if (vidas == 0)
        {
            Morir();
        }
    }

    IEnumerator PantallaDaño()
    {
        UIDaño.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        UIDaño.SetActive(false);
    }


    void RevertCollision()
    {
        // Revert the collision between the two layers after the duration
        Physics.IgnoreLayerCollision(layer1, layer2, false);
    }

    void Morir()
    {
    
        
        Debug.Log(intentos);
        if(intentos == 0)
        {
            Destroy(gameObject);
            CanvasGameOver.SetActive(true);
        }
        else
        {
            gameObject.GetComponent<CharacterController>().enabled = false;
            gameObject.GetComponent<MovementStateManager>().enabled = false;
            gameObject.GetComponent<AimStateManager>().enabled = false;
            gameObject.GetComponent<Animator>().enabled = false;
            gameObject.GetComponent<RigBuilder>().enabled = false;
            gameObject.GetComponent<ActionStateManager>().enabled = false;
            weaponManager.enabled = false;

            CanvasIntentar.SetActive(true);
        }
    }

    public void Reintentar()
    {
        ActualizarUIVidas();
        intentos--;
        gameObject.GetComponent<CharacterController>().enabled = true;
        gameObject.GetComponent<MovementStateManager>().enabled = true;
        gameObject.GetComponent<AimStateManager>().enabled = true;
        gameObject.GetComponent<Animator>().enabled = true;
        gameObject.GetComponent<RigBuilder>().enabled = true;
        gameObject.GetComponent<ActionStateManager>().enabled = true;
        weaponManager.enabled=true;

        vidas = vidasOriginales;
        vidasTexto.text = vidas.ToString();
    }
}
