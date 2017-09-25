using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour {

	public Transform bar;
	public float range = 0.3f;
	public GameObject Point;
	private string choice;


	void Start () {
		
	}
	void SetBase(GameObject Point){
		this.Point = Point;
	}
	void SetChoice(string choice){
		this.choice = choice;
	}
	void Update () {
		bar.transform.localScale = new Vector3 (bar.localScale.x-(Time.deltaTime*range), bar.localScale.y, bar.localScale.z);
		if (bar.localScale.x <= 0) {
			this.Point.SendMessage ("instantiate", this.choice, SendMessageOptions.DontRequireReceiver);
			Destroy (gameObject);
		}
	}
}
