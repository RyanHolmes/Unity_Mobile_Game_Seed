using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Load : MonoBehaviour {

	public float loadTime = 5;
	private float currentTime;

	// Use this for initialization
	void Start () {
		currentTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - currentTime >= loadTime){
			SceneManager.LoadScene ("MenuScene");
		}
	}
}
