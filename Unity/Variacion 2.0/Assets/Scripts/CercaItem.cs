using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CercaItem : MonoBehaviour
{
    public GameObject Item;
    public Material brillo, defaultMaterial;

    private void Start()
    {
        defaultMaterial = Item.GetComponent<MeshRenderer>().material;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && Item != null)
        {
            Item.GetComponent<MeshRenderer>().material = brillo;
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" &&Item != null)
        {
            Item.GetComponent<MeshRenderer>().material = defaultMaterial;
        }
    }
}
