using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TVController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    // Variable to keep track of the number of times "T" is pressed
    private int pressCount = 0;

    void Update()
    {
        // Check if the "T" key is pressed
        if (Input.GetKeyDown(KeyCode.T))
        {
            // Increment the press count
            pressCount++;

            // Check if the press count is even (pressed 2 times)
            if (pressCount % 2 == 0)
            {
                // Start or pause the video based on its current state
                if (videoPlayer.isPlaying)
                {
                    videoPlayer.Pause();
                }
                else
                {
                    videoPlayer.Play();
                }
            }
        }
    }
}
