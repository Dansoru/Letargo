using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public Transform destination; // Objeto al que se teletransportará el jugador

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entró en el trigger es el jugador (puedes ajustar esto según tu configuración)
        if (other.CompareTag("Player"))
        {
            TeleportPlayer(other.transform);
        }
    }

    private void TeleportPlayer(Transform player)
    {
        // Teletransporta al jugador al objeto de destino
        player.position = destination.position;
    }
}
