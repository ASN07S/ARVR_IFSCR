using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ComputerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private int mKeyPressCount = 0;

    void Start()
    {
        // Assuming the video should start paused
        videoPlayer.Pause();
    }

    void Update()
    {
        // Check if the "M" key is pressed
        if (Input.GetKeyDown(KeyCode.M))
        {
            mKeyPressCount++;

            // Toggle between play and pause
            if (mKeyPressCount % 2 == 1)
            {
                videoPlayer.Play();
            }
            else
            {
                videoPlayer.Pause();
            }
        }
    }
}
