using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject UI;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            UI.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(RecargarEscena());
        }
    }


    IEnumerator RecargarEscena()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Nivel2");
    }
}
