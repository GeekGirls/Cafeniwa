using UnityEngine;
using System.Collections;

public class User : MonoBehaviour {
  private int id;
  private string uid;
  private string name;
  private string role;
  private int auth;

  public User() {
    }

  public User(int id, string uid, string name, string role, int auth) {
    this.id = id;
    this.name = name;
    this.role = role;
    this.auth = auth;
  }

  public int getId() {
      return id;
  }

  public string getUid(){
      return uid;
  }

  public string getName() {
      return name;
  }

  public string getRole() {
      return role;
  }

  public int getAuth() {
      return auth;
  }
}
