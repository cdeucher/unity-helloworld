using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Knight : MonoBehaviour {

	void Start () {
		GameObject Tower = Instantiate (Resources.Load ("Prefabs/Soldiers"), new Vector3 (transform.position.x, transform.position.y, transform.position.z), transform.rotation)  as GameObject;
	}
	

	void Update () {
		
	}

}
