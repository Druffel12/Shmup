using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

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
        float MoveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(MoveHorizontal, 0.0f);

        if(Input.GetButtonDown("Jump"))
        {

            RaycastHit Hit;
            if (Physics.Raycast(transform.position, -transform.forward, out Hit, 100))
            {
                if (Hit.collider.tag == "Meteor")
                {
                    Destroy(Hit.collider.gameObject);
                }
            }
        }

        RB.AddForce(movement * Speed);
	}
}
