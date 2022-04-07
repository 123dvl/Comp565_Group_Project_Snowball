using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    private Rigidbody myRB;
    [SerializeField] private int acceleration = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        myRB.AddForce(-transform.forward * acceleration);
        myRB.useGravity = true;
    }
}
