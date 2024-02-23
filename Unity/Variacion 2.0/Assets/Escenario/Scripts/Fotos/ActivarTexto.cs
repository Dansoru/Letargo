using UnityEngine;

public class ActivarTexto : MonoBehaviour
{
    public GameObject textoPulsaE; // Arrastra el objeto de texto al Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que el objeto que colisiona sea el jugador
        {
            textoPulsaE.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textoPulsaE.SetActive(false);
        }
    }
}
