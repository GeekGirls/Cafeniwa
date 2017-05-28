using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogBackground : MonoBehaviour {

	public GameObject dialog;

	// Use this for initialization
	void Start () {
		Button button = GetComponent<Button> ()as Button;
		button.onClick.AddListener (OnClick);
	}

	public void OnClick() {
		dialog.SetActive (false);
	}
}
