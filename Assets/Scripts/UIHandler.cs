using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

	GameObject canvas;
	GameHandler gameHandler;
	private float width;
	private float height;

	GameObject HuntButton;
	GameObject TravelButton;
	GameObject InventoryButton;
	GameObject ShopButton;

	bool MapOpen = false;

	[SerializeField] GameObject button;

	// Use this for initialization
	void Start () {
		this.canvas = GameObject.Find ("UICanvas");
		this.gameHandler = GameObject.Find ("GameHandler").GetComponent<GameHandler> ();

		width = canvas.GetComponent<RectTransform> ().rect.width;
		height = canvas.GetComponent<RectTransform> ().rect.height;

		HuntButton = canvas.transform.FindChild("sidebar").FindChild ("Hunt Button").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		HuntButton.GetComponentInChildren<Text>().text = "Hunt " + (int)(gameHandler.GetHuntTimer ());
	}

	public void ToggleMap()
	{
		if (MapOpen) {
			MapOpen = false;
			canvas.transform.FindChild ("main").gameObject.SetActive (true);
			canvas.transform.FindChild ("map").gameObject.SetActive (false);
		} else {
			MapOpen = true;
			canvas.transform.FindChild ("main").gameObject.SetActive (false);
			canvas.transform.FindChild ("map").gameObject.SetActive (true);
		}
	}
}
