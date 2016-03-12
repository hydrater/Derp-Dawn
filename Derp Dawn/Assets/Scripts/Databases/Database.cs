using UnityEngine;
using System.Collections;

// Script that stores information on everything
public class Database : MonoBehaviour {

	bool debug = false;
	public AreaDatabase area = new AreaDatabase();
	public MonsterDatabase monster = new MonsterDatabase();

	// Use this for initialization
	void Start () {
		monster.Initialize ("Assets//Resources//monsterData.txt");
		area.Initialize ();
		// To Do: traps, bait, crafting recipes

		if (debug) {
			monster.Print();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
