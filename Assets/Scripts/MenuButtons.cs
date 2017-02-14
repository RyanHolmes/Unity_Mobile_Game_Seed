using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {

	public void ClickPlay(){
		SceneManager.LoadScene ("GameScene");
	}

//	public IEnumerator FadeToNextLevel() {
//		float fadetime = Camera.main.GetComponent<SceneFade>().BeginFade(-1);
//		yield return new WaitForSeconds(fadetime);
//		SceneManager.LoadScene("GameScene");
//	}
//
//	public void ClickPlay() {
//		StartCoroutine(FadeToNextLevel());
//	}
}
