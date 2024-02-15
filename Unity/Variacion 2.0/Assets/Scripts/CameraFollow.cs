using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target to follow (the sphere)

    void Update()
    {
        // Ensure the camera follows the sphere's position and rotation
        //transform.position = target.position;
        transform.rotation = target.rotation;
    }
}
