using UnityEngine;
using System.Collections;

// 弾がぶつかった時の処理を書く
public class BulletScript : MonoBehaviour {

	// ぶつかったものが、Playerタグだったらダメージを与える
	void OnCollisionEnter(Collision other){
		
		if (other.gameObject.tag == "Player") {
			other.gameObject.SendMessage("Damage");
		} else if (other.gameObject.tag == "Boss") {
			other.gameObject.SendMessage ("Damage");
		}

		// 自分自身を消す
		Destroy (this.gameObject);
	}
}
