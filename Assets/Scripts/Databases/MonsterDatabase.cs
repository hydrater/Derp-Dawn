using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MonsterDatabase{

	// Script to parse data file and store every monster

	List<Monster> MonsterList = new List<Monster>();

	public MonsterDatabase()
	{

	}

	// To Do: Load data and add into list
	public void Initialize()
	{
		
	}

	public Monster GetMonster(int id)
	{
		foreach (Monster m in MonsterList) {
			if(m.id == id)
			{
				return m;
			}
		}
		return null;
	}

	public Monster GetMonster(string name)
	{
		foreach (Monster m in MonsterList) {
			if(m.name == name)
			{
				return m;
			}
		}
		return null;
	}
}
