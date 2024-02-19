using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Texto : MonoBehaviour
{
    public Text textComponent;
    public string[] mensajes;
    public float duracionMensaje = 3f; // Duración de cada mensaje en segundos
    public float tiempoEntreMensajes = 1f; // Tiempo entre cada mensaje en segundos

    private int index = 0; // Índice del mensaje actual
    private bool mostrandoMensaje = false;

    void Start()
    {
        // Asegúrate de que el texto esté desactivado al iniciar el juego
        textComponent.gameObject.SetActive(false);
        
        // Comienza a mostrar los mensajes
        StartCoroutine(MostrarMensajes());
    }

    IEnumerator MostrarMensajes()
    {
        // Mientras haya mensajes por mostrar
        while (index < mensajes.Length)
        {
            // Activa el texto
            textComponent.gameObject.SetActive(true);

            // Muestra el mensaje actual
            textComponent.text = mensajes[index];

            // Espera la duración del mensaje
            yield return new WaitForSeconds(duracionMensaje);

            // Desactiva el texto
            textComponent.gameObject.SetActive(false);

            // Incrementa el índice para mostrar el siguiente mensaje
            index++;

            // Espera un tiempo antes de mostrar el siguiente mensaje
            yield return new WaitForSeconds(tiempoEntreMensajes);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el objeto que colisionó es el jugador
        if (other.CompareTag("Player"))
        {
            // Inicia la secuencia de mensajes si no se ha iniciado aún
            if (!mostrandoMensaje)
            {
                StartCoroutine(MostrarMensajes());
                mostrandoMensaje = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Comprueba si el objeto que salió de la colisión es el jugador
        if (other.CompareTag("Player"))
        {
            // Reinicia el índice para volver a empezar cuando el jugador regrese
            index = 0;
            mostrandoMensaje = false;
        }
    }
}