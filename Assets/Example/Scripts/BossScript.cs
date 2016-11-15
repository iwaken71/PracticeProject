using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// ボスの体力や状態を管理する
public class BossScript : MonoBehaviour {

	// ボスの体力
	public int BossHP = 500;

	// 体力表示
	public Text HPLabel;

	// 見た目
	Renderer _renderer;

	// ゲームが始まった時に呼ばれる
	void Start () {
		// Rendererという名前のコンポーネントを得る
		_renderer = GetComponent<Renderer> ();
	}
	
	// フレームが変わる度に呼ばれる
	void Update () {
		// 体力表示を更新する
		HPLabel.text = "HP:" + BossHP.ToString ();
	}

	// ダメージを受けた時の処理
	public void Damage(){
		
		BossHP -= 1; // 体力を1減らす

		if (BossHP <= 0) { // 体力が0以下になったら
			
			GameManager.instance.GameClear();
			Destroy (this.gameObject);
		}
	}

	// ボスの色を変える
	public void SetColor(float r,float g,float b){
		_renderer.material.color = new Color (r,g,b,1.0f);
	}
}
