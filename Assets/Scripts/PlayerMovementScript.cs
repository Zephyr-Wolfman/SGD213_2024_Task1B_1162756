using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{
    // Defines a variable for acceleration
    [SerializeField]
    private float acceleration = 5000f;
    // Declares a variable for a Rigidbody component
    private Rigidbody2D ourRigidbody;

    void Start()
    {
        // Gets the Rigidbody component and stores it in ourRigidbody variable
        ourRigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f)
        {
            Vector2 ForceToAdd = Vector2.right * HorizontalInput * acceleration * Time.deltaTime;
            ourRigidbody.AddForce(ForceToAdd);
            //print(HorizontalInput);
        }
    }
}
