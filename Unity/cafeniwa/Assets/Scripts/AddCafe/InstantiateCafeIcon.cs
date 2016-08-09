using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class InstantiateCafeIcon : MonoBehaviour {

	public GameObject cafe_list_field;

	// Use this for initialization
	void Start () {
    //仮のカフェデータ
    Cafe cafe1 = new Cafe(1,"cafe1","sample",1,1,0,1,"pink",0,0);
    Cafe cafe2 = new Cafe(2,"cafe2","sample",1,1,0,1,"pink",0,0);
    Cafe cafe3 = new Cafe(3,"cafe3","sample",1,1,0,1,"pink",0,0);
    List<Cafe> cafe_list = new List<Cafe>();
    cafe_list.Add(cafe1);
    cafe_list.Add(cafe2);
    cafe_list.Add(cafe3);

    //以下データベースが使えるときの処理
    //DataBaseHandler db = new DataBaseHandler();
    //List<Cafe> cafe_list = db.getUnAuthCafes();

		//配置位置の座標
		Vector3 position = new Vector3(0,0,0);
		//生成するprefab
		GameObject cafe_icon_prefab = (GameObject)Resources.Load ("Prefabs/cafe_icon");

			foreach(Cafe cafe in cafe_list){
				string cafe_name = cafe.getName();
	      int cafe_id = cafe.getId();

				GameObject cafe_icon = Instantiate(cafe_icon_prefab, position, Quaternion.identity) as GameObject;
				cafe_icon.transform.parent = cafe_list_field.transform;
        cafe_icon.transform.localScale = new Vector3(1, 1, 1);
        GameObject cafe_image = cafe_icon.transform.FindChild("cafe_image").gameObject;
				cafe_image.AddComponent<Button>();
				cafe_image.GetComponent<Button>().onClick.AddListener(() => onClick(cafe_id));
			}
	}

	// Update is called once per frame
	void Update () {

	}

	void onClick (int id) {
		Debug.Log(id);
		//DataBaseHandler db = new DataBaseHandler();
		//db.AuthenticateCafe(id)

	}
}
