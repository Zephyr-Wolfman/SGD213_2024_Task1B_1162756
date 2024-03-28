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

    public void MoveForward()
    {
        ourRigidbody.velocity = Vector2.down * initialVelocity;
    }

    public void Acceleration()
    {
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }
}
