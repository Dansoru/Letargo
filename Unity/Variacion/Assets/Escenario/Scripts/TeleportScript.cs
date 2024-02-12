using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public Transform teleportDestination; // Asigna el destino del teletransporte en el Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the teleport trigger.");

            TeleportPlayer(other.gameObject, teleportDestination);
        }
    }

    private void TeleportPlayer(GameObject player, Transform destination)
    {
        Debug.Log("Teleporting player to destination.");

        player.transform.position = destination.position;
        // Puedes ajustar la rotación si es necesario
        player.transform.rotation = destination.rotation;

        Debug.Log("Player teleported successfully.");
    }
}
