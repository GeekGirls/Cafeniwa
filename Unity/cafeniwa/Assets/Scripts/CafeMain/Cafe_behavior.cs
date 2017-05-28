using UnityEngine;
using System.Collections;

public class Cafe_behavior : MonoBehaviour {
    
 	void OnMouseEnter() {
        Vector3 tmp = transform.position;
        tmp.y += 1;
        transform.position = tmp;

        GameObject cafeobj;

        if (Input.GetMouseButton(0)) {
        string objectName = this.name;
        string tag = this.transform.parent.tag;
        Debug.Log(objectName);
        }
    }
    void OnMouseExit() {
        Vector3 tmp = transform.position;
        tmp.y -= 1;
        transform.position = tmp;
    	}


//    void activate_dialog(){
//    GameObject dialog = Transform.Find("cafe_info_dialog");
//    dialog.SetActive (true);
//    }




    	    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
    }



}
