using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour, IMovable
{
    [SerializeField]
    private float acceleration = 50f;
    [SerializeField]
    private float initialVelocity = 5f;
    private Rigidbody2D ourRigidbody;

    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Set the bullets upward velocity
    public void MoveForward()
    {
        ourRigidbody.velocity = Vector2.up * initialVelocity;
    }

    // Apply upward force
    public void Acceleration()
    {
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }

}
