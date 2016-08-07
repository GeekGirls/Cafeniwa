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
		coupon2_used.text = "未使用";
		coupon3_used.text = "未使用";
	}

	public void SetCafeInfo (int cafe_id) {
		DataBaseHandler db = new DataBaseHandler();

		Cafe cafe = db.getCafe(cafe_id);
		List<Coupon> coupons = db.getCoupons(cafe_id);
		Coupon coupon1 = coupons[0];
		Coupon coupon2 = coupons[1];
		Coupon coupon3 = coupons[2];

		cafe_name.text = cafe.getName();
		cafe_url.text = cafe.getUrl();
		cafe_count.text = "入店回数：" + cafe.getCount().ToString() + "回";
		coupon1_name.text = coupon1.getName();
		coupon2_name.text = coupon2.getName();
		coupon3_name.text = coupon3.getName();

		if (coupon1.getUsed() == 1) {
				coupon1_used.text = "使用済み";
		}else{
				coupon1_used.text = "未使用";
		}

		if (coupon2.getUsed() == 1) {
				coupon2_used.text = "使用済み";
		}else{
				coupon2_used.text = "未使用";
		}

		if (coupon2.getUsed() == 1) {
				coupon2_used.text = "使用済み";
		}else{
				coupon2_used.text = "未使用";
		}
	}
}
