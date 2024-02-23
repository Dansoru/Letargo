using UnityEngine;
using UnityEngine.SceneManagement;

public class Recolector : MonoBehaviour
{
    public KeyCode teclaRecolectar = KeyCode.E;
    public GameObject objetoRecolectable;
    private bool jugadorDentro = false;
    public string nombreNuevaEscena; // Nombre de la nueva escena a cargar

    private void Update()
    {
        if (jugadorDentro && Input.GetKeyDown(teclaRecolectar))
        {
            RecolectarObjeto();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorDentro = true;
            //Debug.Log("Player dentro del collider");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorDentro = false;
            //Debug.Log("Player fuera del collider");
        }
    }

    private void RecolectarObjeto()
    {
        // Recolectar solo si el jugador está dentro del collider y hay un objeto recolectable
        if (jugadorDentro && objetoRecolectable != null)
        {
            objetoRecolectable.SetActive(false);
           // Debug.Log("Objeto recolectado");

            // Cambiar a la nueva escena
            if (!string.IsNullOrEmpty(nombreNuevaEscena))
            {
                SceneManager.LoadScene(nombreNuevaEscena);
            }
        }
    }
}