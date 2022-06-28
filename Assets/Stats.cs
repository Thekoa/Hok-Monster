using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
	public int currentHealth = 100;
	public int maxHealth = 100;
	public int strength = 0;
	public bool alive=true;
	public bool turn= false;
	public bool dodge=false;
	//public int defence;
	//public int speed;
	
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	
	public void TakeDamage(int amount)
	{	
		
		print("Hero Attack dealt "+amount+"damage");
		currentHealth=-amount;
		if (currentHealth<=0)
		{
			alive=false;
		}
		dodge= false;
	}
	
	public void StrengthChange(int amount)
	{
		print("Hero attack power increase");
		strength=+amount;
	}
}
