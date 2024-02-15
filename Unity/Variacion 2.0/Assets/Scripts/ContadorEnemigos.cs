using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorEnemigos : MonoBehaviour
{
    public TextMeshProUGUI contadorEnemigosTexto;
    public int contadorEnemigos = 8;


    public GameObject UIGanaste;
    public GameObject boss;

    private void Start()
    {
        contadorEnemigosTexto.text = contadorEnemigos.ToString();
    }

    private void Update()
    {
        if(contadorEnemigos == 0)
        {
            boss.SetActive(true);
        }
        if(boss.GetComponent<EnemyHealth>().health == 0)
        {
            UIGanaste.SetActive(true);
        }
    }

    public void UpdateUI()
    {
        contadorEnemigosTexto.text = contadorEnemigos.ToString();
    }

}
