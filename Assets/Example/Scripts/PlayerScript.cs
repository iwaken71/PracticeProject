using UnityEngine;
using System.Collections;

public class PlayerScript :MonoBehaviour {

	public float speed = 3.0f; // Playerの移動スピード
	public float bulletSpeed = 10.0f; // 弾のスピード
	public float rotateSpeed = 30.0f; //回転のスピード

	GameObject bulletPrefab; // 弾の素材
	Transform shotPoint; // 弾お発射の位置
	int playerHP; // PlayerのHP

	GameObject myCamera; // 自分のカメラのオブジェクト

	void Awake(){
		bulletPrefab = Resources.Load ("bullet") as GameObject; // 素材をResourceフォルダからロードする。
		shotPoint = transform.Find ("ShotPoint"); // 発射ポイントを自分の子供から探す
		myCamera = transform.Find ("Main Camera").gameObject; // カメラを自分の子供から探す
	}
		
	void Start () {
		playerHP = 10; //体力を10に設定
	}
		
	// 画面が変わる毎に呼ばれる
	void Update () {
		Move ();
		// スペースキーをおした時
		if (Input.GetKeyDown (KeyCode.Space)) {
			Shot ();
		}
	}

	// 動く時の関数
	void Move(){
		float h = Input.GetAxis ("Horizontal"); //左右キーの入力 -1 ~ 1
		float v = Input.GetAxis ("Vertical"); // 上下キーお入力 -1 ~ 1

		transform.position += transform.forward * v * Time.deltaTime * speed;
		transform.Rotate (new Vector3 (0, rotateSpeed * h * Time.deltaTime, 0));
	}

	// 弾を撃つ時の関数
	void Shot(){
		// 弾を生成する、場所はPoint
  		GameObject obj = Instantiate (bulletPrefab, shotPoint.position, transform.rotation) as GameObject;

		// 弾に速度を与える。方向は前方向、スピードはbulletSpeed
		obj.GetComponent<Rigidbody> ().velocity = transform.forward * bulletSpeed;
	}

	// ダメージを受けた時の処理
	public void Damage(){
		playerHP -= 1;
		if (playerHP <= 0) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Item") {
			speed *= 2;
			Destroy (col.gameObject);
		}

	}
}
