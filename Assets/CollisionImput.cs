using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionImput : MonoBehaviour
{
	public GameObject hero;
	public Stats skills;
	public bool attack;
	public bool gainStrength;
	public bool dodge;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnCollisionEnter()
	{
	//collide and change color
		if(attack == true)
		{
			print("attack");
		}
		else if(gainStrength==true)
		{
			print("defend");
		}
		else if(dodge==true)
		{
			print("dodge");
		}
	}
}
