using UnityEngine;
using System.Collections;

public class TapAbleObject : MonoBehaviour {

	public GameObject dialog;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();

			if (Physics.Raycast(ray, out hit)){
				dialog.SetActive (true);
				SetCafeInfoDialog coupon = dialog.GetComponent<SetCafeInfoDialog> () as SetCafeInfoDialog;
				if (coupon != null) {
					coupon.SetCafeInfoTest ();
				}
			}
		}
	}
}
