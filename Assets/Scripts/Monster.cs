using UnityEngine;
using System.Collections;

public class Monster{

	public enum MonsterType
	{
		NORMAL,
	}

	public Monster()
	{
	}

	private string name;
	private MonsterType type;
	private float strength;
	private int exp;
	private int gold;
	private float encounterRate;

	public void Set(string name, MonsterType type, float strength, int exp, int gold, float encounterRate)
	{
		this.name = name;
		this.type = type;
		this.strength = strength;
		this.exp = exp;
		this.gold = gold;
		this.encounterRate = encounterRate;
	}

	public string GetName() { return this.name; }
	public MonsterType GetType() { return this.type; }
	public float GetStrength() { return this.strength; }
	public int GetExp() { return this.exp; }
	public int GetGold() { return this.gold; }
	public float GetEncounterRate() { return this.encounterRate; }
}
