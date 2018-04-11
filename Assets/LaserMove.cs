using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMove : MonoBehaviour {

    public float Speed;
    public Rigidbody RB;
    // Use this for initialization
    void Start ()
    {
        RB = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        RB.AddForce(transform.up * Speed);
    }
}
