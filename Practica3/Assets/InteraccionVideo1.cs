using UnityEngine;
using UnityEngine.Video;

public class InteraccionVideo1 : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Update()
    {
       
    }

    public void OnPointerClick()
    {
        videoPlayer.Stop();
        videoPlayer.time = 0;
        videoPlayer.Pause();
    }
    
}