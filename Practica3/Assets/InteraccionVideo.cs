using UnityEngine;
using UnityEngine.Video;

public class InteraccionVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private bool isPaused=true;

    void Update()
    {
        if (isPaused)
        {
            videoPlayer.Pause();
        }
        else
        {
            videoPlayer.Play();
        }
    }

    public void OnPointerClick()
    {
        isPaused= !isPaused;
        Update();
    }
    
}