using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
        Debug.Log("Helloo");
            other.transform.SetParent(transform);
        }
    }
  


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
        Debug.Log("Bye");
            other.transform.SetParent(null);
        }
    }
}
