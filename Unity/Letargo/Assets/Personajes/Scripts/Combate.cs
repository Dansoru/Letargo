using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combate : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
{
    if (coll.CompareTag("puño"))
    {
        Debug.Log("attack");
        
    }
}
    
}