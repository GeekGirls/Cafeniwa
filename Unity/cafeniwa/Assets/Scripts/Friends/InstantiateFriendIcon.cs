using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class InstantiateFriendIcon : MonoBehaviour {

  public GameObject friend_list_field;

  // Use this for initialization
  void Start () {

    //以下テストコード
    User friend1 = new User(1,"sample1","アリス","friend",1);
    User friend2 = new User(2,"sample2","ボブ","friend",1);
    User friend3 = new User(3,"sample3","キャロル","friend",1);
    List<User> friend_list = new List<User>();
    friend_list.Add(friend1);
    friend_list.Add(friend2);
    friend_list.Add(friend3);

    //以下データベースが使えるときの処理
    //DataBaseHandler db = new DataBaseHandler();
    //List<User> friend_list = db.getFriends();

    //配置位置の座標
    Vector3 position = new Vector3(0,0,0);
    //生成するprefab
    GameObject friend_icon_prefab = (GameObject)Resources.Load("Prefabs/friend_icon");

      foreach(User friend in friend_list){
        string f_name = friend.getName();
//        int f_id = friend.getId();

        // アイコン生成
        GameObject friend_icon = Instantiate(friend_icon_prefab, position, Quaternion.identity) as GameObject;
        friend_icon.transform.parent = friend_list_field.transform;
        friend_icon.transform.localScale = new Vector3(1, 1, 1);
        // buttonにシーン遷移を持たせる
        GameObject friend_image = friend_icon.transform.FindChild("friend_button").gameObject;
        friend_image.AddComponent<Button>();
        friend_image.GetComponent<Button>().onClick.AddListener(() => onClick());
        // friend_nameを持たせる
        GameObject friend_name = friend_icon.transform.FindChild("friend_name").gameObject;
        friend_name.GetComponent<Text>().text = f_name;
      }

      // add_friend_button
      GameObject add_friend_button_prefab = (GameObject)Resources.Load("Prefabs/add_friend_button");
      GameObject add_friend_button = Instantiate(add_friend_button_prefab, position, Quaternion.identity) as GameObject;
      add_friend_button.transform.parent = friend_list_field.transform;
      add_friend_button.transform.localScale = new Vector3(1, 1, 1);
  }

  // Update is called once per frame
  void Update () {

  }

  void onClick () {
    // TODO: friend_id を CafeMain に渡す
      LoadScene ls = new LoadScene();
      ls.ToCafeMain();
  }
}
