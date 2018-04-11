using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{

    public float Thrust;
    public Rigidbody RB;
	// Use this for initialization
	void Start ()
    {
        RB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        RB.AddForce(transform.forward * Thrust);
   
	}
    void OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "Player")
        {
            Destroy(Player.gameObject);
        }
    }
}
