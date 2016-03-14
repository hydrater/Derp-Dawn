using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

	float trapTimer = 5;
	public Transform panel;
	byte min = 0;
	
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		trapTimer -= Time.deltaTime;
		if (trapTimer < 0)
		{
			--min;
			trapTimer = 60;
			if (min == 255)
			{
				transform.GetChild(8).gameObject.SetActive(false);
				transform.GetChild(9).gameObject.SetActive(true);
			}
		}
		transform.GetChild(8).GetComponent<Text>().text = min.ToString() + "m " + Mathf.Floor(trapTimer).ToString() + "s";
		
	}
	
	public void CheckTrap()
	{
		
	}
	
	public void Map()
	{
		panel.GetChild(0).gameObject.SetActive(false);
		panel.GetChild(1).gameObject.SetActive(true);
	}
	
	public void MapBack()
	{
		panel.GetChild(0).gameObject.SetActive(true);
		panel.GetChild(1).gameObject.SetActive(false);
	}
}
