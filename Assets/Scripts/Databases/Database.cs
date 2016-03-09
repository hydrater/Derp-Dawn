using UnityEngine;
using System.Collections;

// Script that stores information on everything
public class Database : MonoBehaviour {

	public AreaDatabase area = new AreaDatabase();
	public MonsterDatabase monster = new MonsterDatabase();

	// Use this for initialization
	void Start () {
		monster.Initialize ();
		area.Initialize ();
		// To Do: traps, bait, crafting recipes
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
