using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private IMovable movable;

    void Start()
    {
        movable = GetComponent<IMovable>();
        //Initilised forward movement to the object     
        movable.MoveForward();
    }

    void Update()
    {
        // applies acceleration to the object
        movable.Acceleration();
    }
}
