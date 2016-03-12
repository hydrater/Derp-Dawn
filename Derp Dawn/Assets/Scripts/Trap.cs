using UnityEngine;
using System.Collections;

public enum ElementType
{
	NORMAL,
}

public class Trap {

	public Trap() {}

	private string name;
	private float power;
	private ElementType type;
	private float strength;
	private float bonus;

	public void Set(string name, float power, ElementType type, float strength, float bonus)
	{
		this.name = name;
		this.power = power;
		this.type = type;
		this.strength = strength;
		this.bonus = bonus;
	}

	public string GetName() { return this.name; }
	public float GetPower() { return power; }
	public ElementType GetType() { return type; }
	public float GetStrength() { return strength; }
	public float GetBonus() { return bonus; }
}

public class Cage {

	public Cage() {}

	private string name;
	private float power;
	private ElementType type;
	private float strength;
	private float bonus;
	
	public void Set(string name, float power, ElementType type, float strength, float bonus)
	{
		this.name = name;
		this.power = power;
		this.type = type;
		this.strength = strength;
		this.bonus = bonus;
	}
	
	public string GetName() { return this.name; }
	public float GetPower() { return power; }
	public ElementType GetType() { return type; }
	public float GetStrength() { return strength; }
	public float GetBonus() { return bonus; }
}