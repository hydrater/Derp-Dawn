using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Area
{
	public string name;
	// Contains the monsters in the area
	List<Monster> catchableList = new List<Monster>();
}

public class AreaDatabase {

	List<Area> areaList = new List<Area>();
	
	public AreaDatabase()
	{

	}

	// To Do: Load data and add into list
	public void Initialize()
	{

	}

	public Area GetArea(string name)
	{
		foreach(Area a in areaList)
		{
			if(a.name == name)
			{
				return a;
			}
		}
		return null;
	}
}
