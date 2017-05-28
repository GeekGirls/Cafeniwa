using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class toppage : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update (){
        	if(Input.GetMouseButtonDown(0) == true){
        		Debug.Log("touch");
       			SceneManager.LoadScene("cafe_main");
    	}
    }
}
