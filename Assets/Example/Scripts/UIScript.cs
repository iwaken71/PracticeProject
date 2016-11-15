using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

	public Text message;
	public GameObject resultPanel;

	void Update(){
		if (GameManager.instance.gameClear) {
			resultPanel.SetActive (true);
		} else {
			resultPanel.SetActive (false);
		}
	}

	void Start () {
		message.text = "Hello";
	}
	void Nice(string name){
		message.text = name + "Nice!";
	}

	// リトライする
	public void Retry(){
		GameManager.instance.gameClear = false;
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}