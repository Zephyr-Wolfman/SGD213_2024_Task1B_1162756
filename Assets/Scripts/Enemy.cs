using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour, IMovable
{
    [SerializeField]
    private float acceleration = 50f;
    [SerializeField]
    private float initialVelocity = 2f;
    private Rigidbody2D ourRigidbody;

    void Start()
    {
        // Gets the Rigidbody component and stores it in ourRigidbody variable
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Set the enemy downward velocity
    public void MoveForward()
    {
        ourRigidbody.velocity = Vector2.down * initialVelocity;
    }

    // Apply downward force
    public void Acceleration()
    {
        // Calculates force based on direction and acceleration then applies it
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }
}
