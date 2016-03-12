using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// 
public class MapHandler : MonoBehaviour {

	AreaDatabase areas;
	Area currentArea;

	// Use this for initialization
	void Start () {
		areas = GameObject.Find ("Database").GetComponent<Database> ().area;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	bool Travel(string newAreaName)
	{
		Area tempArea = areas.GetArea (newAreaName);
		if (tempArea == null)
			return false;
		else {
			currentArea = tempArea;
			// To Do: Minus player gold
			return true;
		}
	}
}
