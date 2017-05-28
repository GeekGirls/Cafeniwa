using UnityEngine;
using System.Collections;

public class Cafe_behavior : MonoBehaviour {
	public CircleCollider2D col;

	private MainController controller;
	private int id;

    
 	void OnMouseEnter() {
        Vector3 tmp = transform.position;
        tmp.y += 1;
        transform.position = tmp;
		// 当たり判定の場所は動かないようにする
		tmp = col.offset;
		tmp.y -= 1 * col.radius;
		col.offset = tmp;

		//メインコントローラーに自分のIDをセットする
		this.controller.cafe_id = this.id;

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
		tmp = col.offset;
		tmp.y += 1 * col.radius;
		col.offset = tmp;

		this.controller.cafe_id = 0;
    	}


//    void activate_dialog(){
//    GameObject dialog = Transform.Find("cafe_info_dialog");
//    dialog.SetActive (true);
//    }




    	    // Use this for initialization
    void Start () {
		this.col = this.GetComponent<CircleCollider2D> () as CircleCollider2D;
		GameObject controller_object = GameObject.FindWithTag ("GameController");
		this.controller = controller_object.GetComponent<MainController> ()as MainController;
		this.id = int.Parse(transform.parent.gameObject.name);
    }



}
