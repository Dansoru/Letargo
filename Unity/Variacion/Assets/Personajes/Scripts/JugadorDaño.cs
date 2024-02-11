using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorDaño: MonoBehaviour
{
  public int damage;
public GameObject Enemigo;

private void OnTriggerEnter(Collider other)
{
    if (other.tag == "Enemigo")
    {
        Enemigo.GetComponent<DatosEnemigo>().vidaEnemigo -= damage;
    }

    if (other.tag =="Player")
    {
        Debug.Log("esto es un enemigo");
    }
}

}
