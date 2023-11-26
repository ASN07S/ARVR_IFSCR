using UnityEngine;

public class CupboardController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Assuming you have an Animator component attached to the cupboard GameObject
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for input and close the cupboard
        if (Input.GetKeyDown(KeyCode.O))
        {
            CloseCupboard();
        }
    }

    void CloseCupboard()
    {
        // Set the "isOpen" parameter in the animator to false to trigger the close animation
        animator.SetBool("isOpen", false);
    }
}
