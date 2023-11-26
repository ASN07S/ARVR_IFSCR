using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject dvere;
    public float openRot, closeRot, speed;
    private bool opening;

    // Adjust this distance based on how close the player needs to be to interact with the door
    public float interactDistance = 3f;

    void Update()
    {
        // Check if the player is near the door
        if (IsPlayerNearDoor())
        {
            // Open the door when the "O" key is pressed
            if (Input.GetKeyDown(KeyCode.O))
            {
                ToggleDoor();
            }
        }

        Vector3 currentRot = dvere.transform.localEulerAngles;

        if (opening)
        {
            if (currentRot.y < openRot)
            {
                dvere.transform.localEulerAngles = new Vector3(currentRot.x, Mathf.LerpAngle(currentRot.y, openRot, Time.deltaTime * speed), currentRot.z);
            }
        }
        else
        {
            if (currentRot.y > closeRot)
            {
                dvere.transform.localEulerAngles = new Vector3(currentRot.x, Mathf.LerpAngle(currentRot.y, closeRot, Time.deltaTime * speed), currentRot.z);
            }
        }
    }

    private void ToggleDoor()
    {
        opening = !opening;
    }

    private bool IsPlayerNearDoor()
    {
        // Assuming the player has a collider component
        Collider playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider>();

        // Check if the player is within the interactDistance of the door
        return Vector3.Distance(playerCollider.bounds.center, transform.position) <= interactDistance;
    }
}
