using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    public void ToCafeMain () {
		SceneManager.LoadScene("cafe_main");
	}

    public void ToAddCafe () {
		SceneManager.LoadScene("add_cafe");
	}

    public void ToFriends () {
		SceneManager.LoadScene("friends");
	}

    public void ToAddFriend () {
		SceneManager.LoadScene("add_friend");
    }

    public void ToProfile () {
		SceneManager.LoadScene("profile");
    }

    public void ToCreateUser () {
        SceneManager.LoadScene("create_user");
    }
}
