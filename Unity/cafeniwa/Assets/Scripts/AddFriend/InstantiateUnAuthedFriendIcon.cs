using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class InstantiateUnAuthedFriendIcon : MonoBehaviour {

  public GameObject friend_list_field;

  public GameObject add_friend_diralog;

  // Use this for initialization
  void Start () {

    #if UNITY_ANDROID && !UNITY_EDITOR
      // Android で動かしたとき: データベースからデータを取り出す
      DataBaseHandler db = new DataBaseHandler();
      List<User> friend_list = db.getUnAuthFriends();
   #else
      // Unity で動かしたとき: ダミーデータを作る
      User friend1 = new User(1,"sample1","アリス","friend",1);
      User friend2 = new User(2,"sample2","ボブ","friend",1);
      User friend3 = new User(3,"sample3","キャロル","friend",1);
      List<User> friend_list = new List<User>();
      friend_list.Add(friend1);
      friend_list.Add(friend2);
      friend_list.Add(friend3);
    #endif

    //配置位置の座標
    Vector3 position = new Vector3(0,0,0);
    //生成するprefab
    GameObject friend_icon_prefab = (GameObject)Resources.Load("Prefabs/friend_icon");

      foreach(User friend in friend_list){
        User f = friend;

        // アイコン生成
        GameObject friend_icon = Instantiate(friend_icon_prefab, position, Quaternion.identity) as GameObject;
        friend_icon.transform.parent = friend_list_field.transform;
        friend_icon.transform.localScale = new Vector3(1, 1, 1);
        // buttonにダイアログを表示するスクリプトを持たせる
        GameObject friend_image = friend_icon.transform.FindChild("friend_button").gameObject;
        friend_image.AddComponent<Button>();
        friend_image.GetComponent<Button>().onClick.AddListener(() => onClick(f));
        // friend_nameを持たせる
        GameObject friend_name = friend_icon.transform.FindChild("friend_name").gameObject;
        friend_name.GetComponent<Text>().text = f.getName();;
      }
  }

  // Update is called once per frame
  void Update () {

  }

  void onClick (User friend) {
    Debug.Log("追加するフレンド (" + friend.getName() + ")");
    add_friend_diralog.SetActive(true);
    SetAddFriendDialog dialog = add_friend_diralog.GetComponent<SetAddFriendDialog> () as SetAddFriendDialog;
    if (dialog != null){
      dialog.SetAddFriendInfo(friend);
    }
  }
}
