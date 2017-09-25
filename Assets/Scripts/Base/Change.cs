using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

	public GameObject Base;
	public GameObject Point;

	void Start () {
		
	}

	void Update () {

	}
	void OnMouseDown(){
		GameObject Bar = Instantiate (Resources.Load("Prefabs/ProgressBar"), new Vector3 (this.Base.transform.position.x, this.Base.transform.position.y+0.2f, this.Base.transform.position.z), transform.rotation) as GameObject;
		Bar.SendMessage ("SetBase", this.Point, SendMessageOptions.DontRequireReceiver);
		Bar.SendMessage ("SetChoice", gameObject.name, SendMessageOptions.DontRequireReceiver);
		Destroy (this.Base);
	}

	void SetBase(GameObject Point){
		this.Point = Point;
	}


}
