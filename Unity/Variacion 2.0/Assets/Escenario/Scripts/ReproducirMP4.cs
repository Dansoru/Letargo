using UnityEngine;
using UnityEngine.Video;

public class ReproducirMP4 : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que solo el jugador active el video
        {
            ReproducirVideo();
            Debug.Log("Se esta ejecutando el video");
        }
    }

    private void ReproducirVideo()
    {
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }
}