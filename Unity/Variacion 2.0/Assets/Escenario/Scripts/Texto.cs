using UnityEngine;
using TMPro;

public class Texto : MonoBehaviour
{
    public TextMeshProUGUI textoIntroduccion;
    public string[] mensajes = { "Papa??", "¿Donde estás?" };
    public float tiempoEntreMensajes = 3f;
    public float retrasoInicial = 10f;
    private int indiceMensajeActual = 0;

    void Start()
    {
        Invoke("MostrarMensajeDeIntroduccion", retrasoInicial);
    }

    void MostrarMensajeDeIntroduccion()
    {
        if (indiceMensajeActual < mensajes.Length)
        {
            textoIntroduccion.text = mensajes[indiceMensajeActual];
            indiceMensajeActual++;
            Invoke("MostrarMensajeDeIntroduccion", tiempoEntreMensajes);
        }
        else
        {
            // Cuando se muestran todos los mensajes, borramos el texto
            Invoke("BorrarMensaje", tiempoEntreMensajes);
        }
    }

    void BorrarMensaje()
    {
        textoIntroduccion.text = "";
    }
}
