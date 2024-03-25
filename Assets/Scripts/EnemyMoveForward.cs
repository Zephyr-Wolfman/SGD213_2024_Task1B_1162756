using UnityEngine;
using System.Collections;

public class EnemyMoveForward : MonoBehaviour {

    [SerializeField]
    private float acceleration = 75f;

    [SerializeField]
    private float initialVelocity = 2f;

    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        // Gets the Rigidbody component and stores it in variable
        ourRigidbody = GetComponent<Rigidbody2D>();
        // Set initial enemy velocity
        ourRigidbody.velocity = Vector2.down * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // Apply acceleration to enemy
        ApplyEnemyAcceleration();
    }
    // Applies force to the bullet to simulate acceleration
    void ApplyEnemyAcceleration()
    {
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }
}
