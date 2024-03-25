using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float maximumSpinSpeed = 200;

    // Use this for initialization
    void Start()
    {
        RotateObject();
    }

    void RotateObject()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maximumSpinSpeed, maximumSpinSpeed);
    }
}
