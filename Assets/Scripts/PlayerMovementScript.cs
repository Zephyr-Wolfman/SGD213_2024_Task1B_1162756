using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{
    // Defines a variable for acceleration accessible in the inspector
    [SerializeField]
    private float acceleration = 5000f;
    // Declares a variable for a Rigidbody component
    private Rigidbody2D ourRigidbody;

    void Start()
    {
        // Gets the Rigidbody component and stores it in ourRigidbody variable
        ourRigidbody = GetComponent<Rigidbody2D>();
    }
    
    public void HorizontalMovement(float HorizontalInput)
    {
            Vector2 ForceToAdd = Vector2.right * HorizontalInput * acceleration * Time.deltaTime;
            ourRigidbody.AddForce(ForceToAdd);            
    }
}
