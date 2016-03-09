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

		Vector3 buttonPosition = new Vector3();
		buttonPosition.Set (-width * 0.5f + button.GetComponent<RectTransform>().rect.width * 0.5f,
		             height * 0.5f - button.GetComponent<RectTransform>().rect.height * 0.5f,
		             0);

		GameObject UIButton = (GameObject)Instantiate (button, Vector3.zero, Quaternion.identity);
		UIButton.transform.SetParent(canvas.transform);
		UIButton.GetComponent<RectTransform> ().localPosition = buttonPosition;
		UIButton.GetComponentInChildren<Text> ().text = "Hunt " + gameHandler.GetHuntTimer ();
		UIButton.name = "Hunt Button";
		HuntButton = UIButton;

		// Travel button
		buttonPosition.Set (-width * 0.5f + button.GetComponent<RectTransform>().rect.width * 0.5f,
		                    height * 0.5f - button.GetComponent<RectTransform>().rect.height * 1.5f,
		                    0);
		
		UIButton = (GameObject)Instantiate (button, Vector3.zero, Quaternion.identity);
		UIButton.transform.SetParent(canvas.transform);
		UIButton.GetComponent<RectTransform> ().localPosition = buttonPosition;
		UIButton.GetComponentInChildren<Text> ().text = "Travel";
		UIButton.GetComponent<Button> ().onClick.AddListener (ToggleMap);
		UIButton.name = "Travel Button";
		TravelButton = UIButton;

		// Inventory button
		buttonPosition.Set (-width * 0.5f + button.GetComponent<RectTransform>().rect.width * 0.5f,
		                    height * 0.5f - button.GetComponent<RectTransform>().rect.height * 2.5f,
		                    0);

		UIButton = (GameObject)Instantiate (button, Vector3.zero, Quaternion.identity);
		UIButton.transform.SetParent(canvas.transform);
		UIButton.GetComponent<RectTransform> ().localPosition = buttonPosition;
		UIButton.GetComponentInChildren<Text> ().text = "Inventory";
		UIButton.name = "Inventory Button";
		InventoryButton = UIButton;


		// Shop button
		buttonPosition.Set (-width * 0.5f + button.GetComponent<RectTransform>().rect.width * 0.5f,
		                    height * 0.5f - button.GetComponent<RectTransform>().rect.height * 2.5f,
		                    0);
		
		UIButton = (GameObject)Instantiate (button, Vector3.zero, Quaternion.identity);
		UIButton.transform.SetParent(canvas.transform);
		UIButton.GetComponent<RectTransform> ().localPosition = buttonPosition;
		UIButton.GetComponentInChildren<Text> ().text = "Shop";
		UIButton.name = "Shop Button";
		ShopButton = UIButton;
	}
	
	// Update is called once per frame
	void Update () {
		HuntButton.GetComponentInChildren<Text>().text = "Hunt " + (int)(gameHandler.GetHuntTimer ());
	}

	void ToggleMap()
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
