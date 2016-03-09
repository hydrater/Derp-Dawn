using UnityEngine;
using System.Collections;

public class GameHandler : MonoBehaviour {

	private float HuntCooldown = 900;
	private float HuntTimer;
	private bool HuntReady = false;

	// Use this for initialization
	void Start () {
		HuntTimer = HuntCooldown;
	}
	
	// Update is called once per frame
	void Update () {
		if (!HuntReady) {
			HuntTimer -= Time.deltaTime;
			if (HuntTimer <= 0) {
				HuntReady = true;
				HuntTimer = 0;
			}
		}
	}

	public void Hunt()
	{
		HuntReady = false;
		HuntTimer = HuntCooldown;
	}

	public float GetHuntTimer()
	{
		return HuntTimer;
	}
}
