using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

	public Text text;
	public GameObject coupon_dialog;

	public int cafe_id = 0;

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
		if (Input.GetMouseButtonUp(0)
			&& !coupon_dialog.activeInHierarchy
			&& cafe_id != 0){
			Debug.Log (cafe_id);
			ShowCafeInfoDialog ();
		}
	}

	void ShowCafeInfoDialog() {
		SetCafeInfoDialog dialog_script = coupon_dialog.GetComponent<SetCafeInfoDialog> () as SetCafeInfoDialog;
		dialog_script.SetCafeInfoTest ();
		coupon_dialog.SetActive (true);
	}
}
	