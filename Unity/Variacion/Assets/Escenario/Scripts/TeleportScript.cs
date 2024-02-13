using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public Transform teleportDestination; // Asigna el destino del teletransporte en el Inspector
    private CharacterController characterController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            characterController = other.GetComponent<CharacterController>();

            if (characterController != null)
            {
                TeleportPlayer(other.gameObject, teleportDestination);
            }
        }
    }

    private void TeleportPlayer(GameObject player, Transform destination)
    {

        // Establece la posición del CharacterController al destino
        characterController.enabled = false; // Desactiva temporalmente el CharacterController para modificar su posición
        player.transform.position = destination.position;
        characterController.enabled = true; // Reactiva el CharacterController después de modificar la posición
    }
}
