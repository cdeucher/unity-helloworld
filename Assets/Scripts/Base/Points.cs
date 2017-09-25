using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {

	public GameObject Base;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//1 - step -> to change
	void OnMouseDown(){
		GameObject changed = Instantiate (Resources.Load ("Prefabs/Change"), new Vector3 (transform.position.x, transform.position.y + 0.2f, transform.position.z), transform.rotation) as GameObject;
		Transform[] ts = changed.GetComponentsInChildren<Transform> (true);
		foreach (Transform un in ts) {
			un.SendMessage ("SetBase", gameObject, SendMessageOptions.DontRequireReceiver);
		}
	}
	//3 - step -> progress ended
	public void instantiate(string choice){
		Debug.Log (choice);
		GameObject Tower;

		switch (choice) {
		case "Kt":
			Tower = Instantiate (Resources.Load ("Prefabs/Tower_Knight"), new Vector3 (transform.position.x, transform.position.y + 0.2f, transform.position.z), transform.rotation)  as GameObject;
			break;
		case "At":
			Tower = Instantiate (Resources.Load ("Prefabs/Tower_Arrow"), new Vector3 (transform.position.x, transform.position.y + 0.2f, transform.position.z), transform.rotation)  as GameObject;
			break;
		case "Mt":
			Tower = Instantiate (Resources.Load ("Prefabs/Tower_Mage"), new Vector3 (transform.position.x, transform.position.y + 0.2f, transform.position.z), transform.rotation)  as GameObject;
			break;
		}
			
  	    Destroy (this.Base);
		Destroy (gameObject);
	}
}
