using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SetAddFriendDialog : MonoBehaviour {

  public Text friend_name;

  public Button ok_button;
  public Button cancel_button;

  public GameObject add_friend_diralog;

  private User current_friend;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

  public void SetAddFriendInfo (int f_id){
    //以下データベースが使えるときのコード
    //DataBaseHandler db = new DataBaseHandler();
    //current_friend = db.getCafe(cafe_id);
    current_friend = new User(1,"sample1","アリス","friend",1);

    friend_name.text = current_friend.getName();

    ok_button.onClick.AddListener(() => OkClick());
    cancel_button.onClick.AddListener(() => CancelClick());
  }

  void OkClick(){
    //以下データベースが使えるときのコード
    //DataBaseHandler db = new DataBaseHandler();
    //db.AuthenticateFriend(current_cafe.getId());
    add_friend_diralog.SetActive(false);
  }

  void CancelClick(){
    add_friend_diralog.SetActive(false);
  }
}
