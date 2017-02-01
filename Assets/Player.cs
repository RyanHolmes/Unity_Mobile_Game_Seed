using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Vector3 target;

	void Start () {
		target = this.transform.position;
		this.GetComponent<Renderer> ().material.color = Color.white;
	}
	
	void Update () {
		this.transform.position = Vector3.Lerp (this.transform.position, target, Time.deltaTime * 7);
	}

	public void OnTouchDown(Vector3 point){
		this.GetComponent<Renderer> ().material.color = Color.red;
	}

	public void OnTouchHold(Vector3 point){
		this.GetComponent<Renderer> ().material.color = Color.red;
		target = new Vector3 (point.x, this.transform.position.y, this.transform.position.z);
	}

	public void OnTouchUp(Vector3 point){
		this.GetComponent<Renderer> ().material.color = Color.white;
	}
}
