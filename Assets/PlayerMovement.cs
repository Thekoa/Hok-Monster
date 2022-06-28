using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed;
	private bool canMove = false;
    private Rigidbody rb;

	
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		//player can only move when canMove is true
		if (canMove==true)
		{
			if(Input.GetKeyDown("w"))	
			{
				rb.AddForce (0,0,speed);
				print("You Have Taken A Turn");
			}else if(Input.GetKeyDown("s"))	
			{
				rb.AddForce (0,0,-speed);
				print("You Have Taken A Turn");
			}else if(Input.GetKeyDown("a"))	
			{
				rb.AddForce (-speed,0,0);
				print("You Have Taken A Turn");
			}else if(Input.GetKeyDown("d"))	
			{
				rb.AddForce (speed,0,0);
				print("You Have Taken A Turn");
			}
			canMove=false;
		}
		
		if(rb.velocity.magnitude == 0.0f)
		{
			canMove = true;
		}
    }
	
	void OnTriggerEnter (Collider target)
	{
		if(target.tag == "Wall")
		{
		GetComponent<Rigidbody>().velocity = Vector3.zero;
		GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
		//when velocity is 0 the player can move
		canMove = true;
		print("Can move");
		}
	}
}	