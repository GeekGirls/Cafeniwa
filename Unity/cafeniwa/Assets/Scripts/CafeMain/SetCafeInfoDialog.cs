using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SetCafeInfoDialog : MonoBehaviour {

	public Text cafe_name;
	public Text cafe_url;
	public Text cafe_count;
	public Text coupon1_name;
	public Text coupon2_name;
	public Text coupon3_name;
	public Text coupon1_used;
	public Text coupon2_used;
	public Text coupon3_used;

	public Button coupon1_button;
	public Button coupon2_button;
	public Button coupon3_button;

	// Use this for initialization
	void Start () {
		SetCafeInfoTest();
	}

	// Update is called once per frame
	void Update () {
	}

	public void SetCafeInfoTest () {
		cafe_name.text = "Cafe name";
		cafe_url.text = "http://cafe_url.com";
		cafe_count.text = "入店回数：5回";
		coupon1_name.text = "ケーキ5%オフ";
		coupon2_name.text = "コーヒー10%オフ";
		coupon3_name.text = "ケーキセット5%オフ";
		coupon1_used.text = "使用済み";
		coupon1_button.interactable = false;
		coupon2_used.text = "未使用";
		coupon2_button.onClick.AddListener(() => onClick(1));
		coupon3_used.text = "使用不可";
		coupon3_button.interactable = false;
	}

	public void SetCafeInfo (int cafe_id) {
		DataBaseHandler db = new DataBaseHandler();

		Cafe cafe = db.getCafe(cafe_id);
		List<Coupon> coupons = db.getCoupons(cafe_id);
		Coupon coupon1 = coupons[0];
		Coupon coupon2 = coupons[1];
		Coupon coupon3 = coupons[2];
		int visit_count = cafe.getCount();

		cafe_name.text = cafe.getName();
		cafe_url.text = cafe.getUrl();
		cafe_count.text = "入店回数：" + cafe.getCount().ToString() + "回";
		coupon1_name.text = coupon1.getName();
		coupon2_name.text = coupon2.getName();
		coupon3_name.text = coupon3.getName();

		if (visit_count >= coupon1.getLevel()){ // 入店回数とクーポンの使えるレベルを比較
			if (coupon1.getUsed() == 1) { // クーポンが使用済みかどうか
				coupon1_used.text = "使用済み";
				coupon1_button.interactable = false;
			}else{
				coupon1_used.text = "未使用";
				coupon1_button.onClick.AddListener(() => onClick(coupon1.getId()));
			}
		}else{
			coupon1_used.text = "使用不可";
			coupon1_button.interactable = false;
		}

		if (visit_count >= coupon2.getLevel()){
			if (coupon2.getUsed() == 1) {
				coupon2_used.text = "使用済み";
				coupon2_button.interactable = false;
			}else{
				coupon2_used.text = "未使用";
				coupon2_button.onClick.AddListener(() => onClick(coupon2.getId()));
			}
		}else{
			coupon2_used.text = "使用不可";
			coupon2_button.interactable = false;
		}

		if (visit_count >= coupon3.getLevel()){
			if (coupon3.getUsed() == 1) {
				coupon3_used.text = "使用済み";
				coupon3_button.interactable = false;
			}else{
				coupon3_used.text = "未使用";
				coupon3_button.onClick.AddListener(() => onClick(coupon3.getId()));
			}
		}else{
			coupon3_used.text = "使用不可";
			coupon3_button.interactable = false;
		}
	}

	void onClick (int coupon_id) {
		// coupon_dialog を表示して
		// coupon_id を引数に SetCouponInfo を呼び出す
		// ただし，データベースが使えないときは， SetCouponInfoTest を呼び出す
	}
}
