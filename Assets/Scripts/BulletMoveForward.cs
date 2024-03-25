using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour
{

    private float acceleration = 50f;
    private float initialVelocity = 5f;
    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        // Gets the Rigidbody component and stores it in variable
        ourRigidbody = GetComponent<Rigidbody2D>();
        // Set initial bullet velocity
        ourRigidbody.velocity = Vector2.up * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // Apply acceleration to bullet
        ApplyBulletAcceleration();
    }
    // Applies force to the bullet to simulate acceleration
    void ApplyBulletAcceleration()
    {
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }
}
