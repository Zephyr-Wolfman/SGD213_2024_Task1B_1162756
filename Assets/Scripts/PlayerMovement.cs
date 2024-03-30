using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float acceleration = 5000f;
    private Rigidbody2D ourRigidbody;

    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Applies horizontal force based on input
    public void HorizontalMovement(float HorizontalInput)
    {
        // Calculates force based on input and acceleration then applies it
        Vector2 ForceToAdd = Vector2.right * HorizontalInput * acceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }
}
