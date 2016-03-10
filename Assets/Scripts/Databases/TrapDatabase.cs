using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrapDatabase : MonoBehaviour {

	private List<Trap> trapList = new List<Trap>();
	private List<Cage> cageList = new List<Cage>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Trap GetTrap(int id)
	{
		return trapList [id];
	}

	public Trap GetTrap(string name)
	{
		foreach (Trap t in trapList) {
			if(t.GetName() == name)
				return t;
		}
		return null;
	}
}
