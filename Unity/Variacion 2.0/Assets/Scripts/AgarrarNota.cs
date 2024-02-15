using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarrarNota : MonoBehaviour
{

    public GameObject Instrucciones, Puerta;
    public AudioSource AbrirPuerta, TocarPuerta;

    private void Update()
    {
        if (Instrucciones.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Instrucciones.SetActive(false);
                CerrarNota();
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Instrucciones.SetActive(true);
        }
    }

    public void CerrarNota()
    {
        AbrirPuerta.Play();
        Puerta.GetComponent<Animator>().enabled = true;
        StartCoroutine(SonidoTocarPuerta());
    }

    IEnumerator SonidoTocarPuerta()
    {
        yield return new WaitForSeconds(3f);
        TocarPuerta.Play();
    }
}
