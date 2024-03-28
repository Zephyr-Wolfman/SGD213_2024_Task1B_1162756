using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Shooting shooting;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        shooting = GetComponent<Shooting>();
    }

    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f)
        {
            playerMovement.HorizontalMovement(HorizontalInput);
        }

        if (Input.GetButton("Fire1"))
        {
            shooting.Shoot();
        }

    }
}
