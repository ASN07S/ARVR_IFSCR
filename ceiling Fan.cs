using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingFan : MonoBehaviour
{
    float spinSpeed = 1500.0f;
    bool isRotating = false;
    int leftClickCount = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Check for right mouse button click to start rotation
        if (Input.GetMouseButtonDown(1)) // 1 corresponds to the right mouse button
        {
            isRotating = true;
        }

        // Check for left mouse button click to stop rotation after 2 clicks
        if (Input.GetMouseButtonDown(0)) // 0 corresponds to the left mouse button
        {
            leftClickCount++;

            if (leftClickCount >= 2)
            {
                isRotating = false;
                leftClickCount = 0; // Reset the click count
            }
        }

        if (isRotating)
        {
            // Calculate the rotation amount based on the spinSpeed
            float rotationAmount = spinSpeed * Time.deltaTime;

            // Create a rotation quaternion based on the rotation amount around the y-axis
            Quaternion deltaRotation = Quaternion.Euler(0, rotationAmount, 0);

            // Apply the rotation to the current rotation, only affecting the y-axis
            transform.rotation = deltaRotation * transform.rotation;
        }
    }
}
