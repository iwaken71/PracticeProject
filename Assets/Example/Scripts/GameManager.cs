using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public bool gameClear;

	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}

	void Start () {
		MakePlayer (0);
		gameClear = false;
	}

	// Playerをnumber個生成する
	void MakePlayer(int number){
		GameObject playerSozai = Resources.Load ("CubePlayer") as GameObject; 
		for (int i = 0; i < number; i++) {
			GameObject playerObj = Instantiate (playerSozai);
			playerObj.transform.position = new Vector3 (Random.Range(-40,40),0.5f,Random.Range(-40,40));
			playerObj.transform.Rotate (0,Random.Range(0,360),0);
		}
	}
	// ゲームクリアした時に呼ぶ
	public void GameClear(){
		gameClear = true;
	}
}
