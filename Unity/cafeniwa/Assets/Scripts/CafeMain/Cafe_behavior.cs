using UnityEngine;
using System.Collections;

public class Cafe_behavior : MonoBehaviour {
	public CircleCollider2D col;

    
 	void OnMouseEnter() {
        Vector3 tmp = transform.position;
        tmp.y += 1;
        transform.position = tmp;
		tmp = col.offset;
		tmp.y -= 1 * col.radius;
		col.offset = tmp;

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
    	}


//    void activate_dialog(){
//    GameObject dialog = Transform.Find("cafe_info_dialog");
//    dialog.SetActive (true);
//    }




    	    // Use this for initialization
    void Start () {
		this.col = this.GetComponent<CircleCollider2D> () as CircleCollider2D;
    }

    // Update is called once per frame
    void Update () {
    }



}
