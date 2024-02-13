using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public Transform teleportDestination; // Asigna el destino del teletransporte en el Inspector
    private CharacterController characterController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the teleport trigger.");

            characterController = other.GetComponent<CharacterController>();

            if (characterController != null)
            {
                TeleportPlayer(other.gameObject, teleportDestination);
            }
            else
            {
                Debug.LogError("CharacterController not found on the player GameObject.");
            }
        }
    }

    private void TeleportPlayer(GameObject player, Transform destination)
    {
        Debug.Log("Teleporting player to destination.");

        // Establece la posición del CharacterController al destino
        characterController.enabled = false; // Desactiva temporalmente el CharacterController para modificar su posición
        player.transform.position = destination.position;
        characterController.enabled = true; // Reactiva el CharacterController después de modificar la posición

        Debug.Log("Player teleported successfully.");
    }
}
