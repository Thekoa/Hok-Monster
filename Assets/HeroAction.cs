using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAction : MonoBehaviour
{
	public Stats myStats;
	public  Stats enemyStats;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		myStats = GetComponent<Stats>();
        enemyStats=GameObject.Find("BattleMaster").GetComponent<BattleManager>().enemyStats;
    }
	
	void Dodge()
	{
		myStats.dodge= true;
	}
	
	void Attack()
	{
		enemyStats.TakeDamage(myStats.strength);
	}
	
	void GainStrength()
	{
		myStats.StrengthChange(5);
	}
	
}
