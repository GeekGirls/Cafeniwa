using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SetCouponDialog : MonoBehaviour {

	public Text coupon_name;
	public Button ok_button;
  public Button cancel_button;

  public GameObject coupon_dialog;
  public GameObject cafe_dialog;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void SetCouponInfoTest(){
		coupon_name.text = "コーヒー10%オフ";
		int n = 0;
		ok_button.onClick.AddListener(() => onOkClick(n));
    cancel_button.onClick.AddListener(() => onCancelClick());
  }

	public void SetCouponInfo(int coupon_id){
		DataBaseHandler db = new DataBaseHandler();

		Coupon coupon = db.getCoupon(coupon_id);
		coupon_name.text = coupon.getName();
		ok_button.onClick.AddListener(() => onOkClick(coupon.getId()));
    cancel_button.onClick.AddListener(() => onCancelClick());
	}

	void onOkClick(int coupon_id){
		Debug.Log("クーポンID：" + coupon_id.ToString());
    coupon_dialog.SetActive(false);

		// 以下データベースが使えるときの処理
		//DataBaseHandler db = new DataBaseHandler();
		//Coupon coupon = db.UserCoupon(coupon_id);
		//int coupon_id = coupon.getId();
		//db.UseCoupon(int coupon_id);

    cafe_dialog.SetActive(true);
    SetCafeInfoDialog cafe = cafe_dialog.GetComponent<SetCafeInfoDialog> () as SetCafeInfoDialog;
    if (cafe != null) {
      cafe.SetCafeInfoTest ();
    }
	}

  void onCancelClick(){
    coupon_dialog.SetActive(false);
    cafe_dialog.SetActive(true);
    SetCafeInfoDialog cafe = cafe_dialog.GetComponent<SetCafeInfoDialog> () as SetCafeInfoDialog;
    if (cafe != null) {
      cafe.SetCafeInfoTest ();
    }
  }
}
