using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
	public Stats enemyStats;
	public Stats heroStats;
	public GameObject enemyMonster;
	public GameObject hero;
	
    // Start is called before the first frame update
    void Start()
    {
        heroStats = hero.GetComponent<Stats>();
		enemyStats = enemyMonster.GetComponent<Stats>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (enemyStats.alive==false)
		{
			//NextLevel
			print("nice you have won");
		}else if (heroStats.alive==false)
		{
			print("Death");
			//Retry Level
		}
    }
	
	
}
