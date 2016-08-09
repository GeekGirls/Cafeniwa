using UnityEngine;
using System.Collections;

public class Cafe : MonoBehaviour {
	private int id;
	private string name;
	private string url;
	private int count;
	private int user_id;
	private int auth;
	private int image_number;
	private string color;
	private int object_number;
	private int block_number;

	public Cafe(int id, string name, string url, int count, int user_id, int auth, int image_number, string color, int object_number, int block_number){
		this.id = id;
		this.name = name;
		this.url = url;
		this.count = count;
		this.user_id = user_id;
		this.auth = auth;
		this.image_number = image_number;
		this.color = color;
		this.object_number = object_number;
		this.block_number = block_number;
	}


	public int getId() {
        return id;
	}

	public string getName() {
        return name;
	}

	public string getUrl() {
        return url;
	}

	public int getCount() {
        return count;
	}

	public int getUserId() {
		return user_id;
	}

	public int getAuth() {
		return auth;
	}

	public int getImageNumber() {
		return image_number;
	}

	public string getColor() {
		return color;
	}

	public int getObjectNumber() {
		return object_number;
	}

	public int getBlockNumber() {
		return block_number;
	}
}
