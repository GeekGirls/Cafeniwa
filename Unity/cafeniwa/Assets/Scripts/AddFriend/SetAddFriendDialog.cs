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

  public void SetAddFriendInfo (User friend){
    current_friend = friend;

    friend_name.text = current_friend.getName();

    ok_button.onClick.AddListener(() => OkClick());
    cancel_button.onClick.AddListener(() => CancelClick());
  }

  void OkClick(){
    #if UNITY_ANDROID && !UNITY_EDITOR
      // Android で動かしたとき: 友達を認証してダイアログを閉じる
      DataBaseHandler db = new DataBaseHandler();
      db.AuthenticateFriend(current_friend.getId());
      add_friend_diralog.SetActive(false);
    #else
      // Unity で動かしたとき: ダイアログを閉じる
      add_friend_diralog.SetActive(false);
    #endif
  }

  void CancelClick(){
    add_friend_diralog.SetActive(false);
  }
}
