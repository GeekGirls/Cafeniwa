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

  public void ToAddCafe () {
		SceneManager.LoadScene("add_cafe");
	}

  public void ToAddFriend () {
		SceneManager.LoadScene("add_friend");
	}

	public void ToProfile () {
		SceneManager.LoadScene("profile");
	}
}
