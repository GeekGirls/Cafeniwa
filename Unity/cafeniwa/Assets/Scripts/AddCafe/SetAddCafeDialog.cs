using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SetAddCafeDialog : MonoBehaviour {

  public Text cafe_name;
  public Text cafe_url;

  public Button cafe_image1;
  public Button cafe_image2;
  public Button cafe_image3;
  public Button cafe_image4;
  public Button cafe_image5;
  public Button cafe_image6;
  public Button cafe_image7;
  public Button cafe_image8;
  public Button cafe_image9;

  public Button ok_button;
  public Button cancel_button;

  public GameObject selected;
  public GameObject add_cafe_diralog;

  private string selected_cafe_image;

  private Cafe current_cafe;

	// Use this for initialization
	void Start () {
    SetAddCafeInfo(1);
	}

	// Update is called once per frame
	void Update () {

	}

  public void SetAddCafeInfo (int cafe_id) {
    //以下テストコード
    current_cafe = new Cafe(1,"cafe1","sample",1,1,0,1,"pink",0,0);

    //以下データベースが使えるときのコード
    //DataBaseHandler db = new DataBaseHandler();
    //current_cafe = db.getCafe(cafe_id);

    cafe_name.text = current_cafe.getName();
    cafe_url.text = current_cafe.getUrl();
    selected_cafe_image = null;

    cafe_image1.onClick.AddListener(() => SelectCafeImage(cafe_image1));
    cafe_image2.onClick.AddListener(() => SelectCafeImage(cafe_image2));
    cafe_image3.onClick.AddListener(() => SelectCafeImage(cafe_image3));
    cafe_image4.onClick.AddListener(() => SelectCafeImage(cafe_image4));
    cafe_image5.onClick.AddListener(() => SelectCafeImage(cafe_image5));
    cafe_image6.onClick.AddListener(() => SelectCafeImage(cafe_image6));
    cafe_image7.onClick.AddListener(() => SelectCafeImage(cafe_image7));
    cafe_image8.onClick.AddListener(() => SelectCafeImage(cafe_image8));
    cafe_image9.onClick.AddListener(() => SelectCafeImage(cafe_image9));

    ok_button.onClick.AddListener(() => OkClick());
    cancel_button.onClick.AddListener(() => CancelClick());
  }

  void SelectCafeImage(Button cafe_image){
    selected_cafe_image = cafe_image.name;
    selected.transform.parent = cafe_image.transform;
    selected.transform.localPosition = new Vector3(0, 0, 0);
    Debug.Log(selected_cafe_image);
  }

  void OkClick(){
    //以下データベースが使えるときのコード
    //DataBaseHandler db = new DataBaseHandler();
    //db.AuthenticateCafe(current_cafe.getId(), "color", selected_cafe_image);

    Debug.Log(current_cafe.getId());
    Debug.Log(selected_cafe_image);
    add_cafe_diralog.SetActive(false);
  }

  void CancelClick(){
    add_cafe_diralog.SetActive(false);
  }
}
