using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

	public Text text;
	public GameObject coupon_dialog;

	// Use this for initialization
	void Start () {
		if (text != null) {
			DataBaseHandler db = new DataBaseHandler ();
			User user = db.getUser (1);
			text.text = user.getName () + "のカフェ庭";
		}
		coupon_dialog.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
