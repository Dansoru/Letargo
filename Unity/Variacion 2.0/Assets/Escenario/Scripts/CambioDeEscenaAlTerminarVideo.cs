using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CambioDeEscenaAlTerminarVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Arrastra tu VideoPlayer aquí desde el Inspector
    public string nombreDeEscenaACambiar = "Hospital BOSS";

    private void Start()
    {
        if (videoPlayer == null)
        {
            // Si el VideoPlayer no está asignado, intenta encontrarlo en el mismo objeto
            videoPlayer = GetComponent<VideoPlayer>();
        }

        if (videoPlayer != null)
        {
            // Suscribirse al evento de finalización del video
            videoPlayer.loopPointReached += OnVideoTerminado;
        }
        else
        {
            Debug.LogError("VideoPlayer no encontrado. Asigna el VideoPlayer en el Inspector o adjunta uno al mismo objeto.");
        }
    }

    private void OnVideoTerminado(VideoPlayer vp)
    {
        // Cambiar a la nueva escena cuando se complete el video
        SceneManager.LoadScene(nombreDeEscenaACambiar);
    }
}