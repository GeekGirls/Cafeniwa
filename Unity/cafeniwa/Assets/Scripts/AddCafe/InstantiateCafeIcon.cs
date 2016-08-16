using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class InstantiateCafeIcon : MonoBehaviour {

	public GameObject cafe_list_field;

    public GameObject add_cafe_diralog;

	// Use this for initialization
	void Start () {
        Debug.Log("**********************");

        //以下テスコード
        #if UNITY_ANDROID && !UNITY_EDITOR
          DataBaseHandler db = new DataBaseHandler();
          List<Cafe> cafe_list = db.getUnAuthCafes();
        #else
          Cafe cafe1 = new Cafe(1,"cafe1","sample",1,1,0,1,"pink",0,0);
          Cafe cafe2 = new Cafe(2,"cafe2","sample",1,1,0,1,"pink",0,0);
          Cafe cafe3 = new Cafe(3,"cafe3","sample",1,1,0,1,"pink",0,0);
          List<Cafe> cafe_list = new List<Cafe>();
          cafe_list.Add(cafe1);
          cafe_list.Add(cafe2);
          cafe_list.Add(cafe3);
        #endif

          //配置位置の座標
          Vector3 position = new Vector3(0,0,0);
          //生成するprefab
          GameObject cafe_icon_prefab = (GameObject)Resources.Load ("Prefabs/cafe_icon");

          foreach(Cafe cafe in cafe_list){
              Cafe c = cafe;
              // string cafe_name = cafe.getName();
              //   int cafe_id = cafe.getId();

              // アイコン生成
              GameObject cafe_icon = Instantiate(cafe_icon_prefab, position, Quaternion.identity) as GameObject;
              cafe_icon.transform.parent = cafe_list_field.transform;
              cafe_icon.transform.localScale = new Vector3(1, 1, 1);
              // buttonにダイアログを表示するスクリプトを持たせる
              GameObject cafe_image = cafe_icon.transform.FindChild("cafe_button").gameObject;
              cafe_image.AddComponent<Button>();
              cafe_image.GetComponent<Button>().onClick.AddListener(() => onClick(c));
              // cafe_nameを持たせる
              GameObject cafe_name = cafe_icon.transform.FindChild("cafe_name").gameObject;
              cafe_name.GetComponent<Text>().text = c.getName();
          }
    }

	// Update is called once per frame
	void Update () {

	}

	void onClick (Cafe c) {
        Debug.Log("追加するカフェ (" + c.getName() + ")");
        add_cafe_diralog.SetActive(true);
        SetAddCafeDialog dialog = add_cafe_diralog.GetComponent<SetAddCafeDialog> () as SetAddCafeDialog;
        if (dialog != null){
            dialog.SetAddCafeInfo(c);
        }
	}
}
