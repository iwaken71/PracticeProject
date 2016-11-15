#README 

![aaa](http://i.giphy.com/3o6ZsYmRkjQzX1KcQU.gif)

すでにあるゲームのコードをいじることでプログラミングを楽しく効率良く学ぼうという試みです。

プログラミング初心者が**モチベを保ちつつ**Unityの知識を深めるためには、自分が書いたコードがゲームにダイレクトに反映される経験が大事だと思っています。

やはりプログラミングは反応がある方が楽しいです。

今回はそのためのサンプルプロジェクトを作りました。

[Sample Project をダウンロード](
https://drive.google.com/open?id=0Bx6Sj9nvABSxUmt5WXM3X3N5bTg)

# Sample Projectで使われている知識

+ 変数
+ ベクトル
+ if文
+ Input.GetKey
+ 関数
+ OnCollision,OnTrigger
+ Instantiate
+ UI
+ GetComponent
+ for文
+ GameManager
+ Destroy
+ Resources.Load
+ transform.Find
+ SceneManager 
+ Random.Range

# 使い方

1. 学習者と指導者はこのプロジェクトをダウンロードしインポートする。

2. 指導者は学習者に学習単元が理解していればできるような、課題を出す。
課題とは、プロジェクトの機能追加や変更である。

# 課題の例

## 変数
+ ボスの初期体力を10に設定しよう。
+ 弾の威力を5に変更しよう。
+ 初期状態で生成するプレイヤーの数を変数で設定できるようにしよう。 (ヒント: GameManagerクラス)

## ベクトル
+ 弾を常に真上に発射するようにしよう。
+ 上キーを押したら、z軸方向に進むようにしよう。

## Input.GetKey

+ スペースキーを押したら、弾を出し続けられるようにしよう
+ スペースキーではなく、[xキー]を押したら弾がでるようにしよう

## 関数
+ つねに弾が発射されるように、Shot関数を書く場所を変えよう。

こんな感じで、指導者は学習者にとって丁度いい課題を考えます。
ポイントは、コードの変更がすぐにゲームに反映されるのがわかることだと思っています。

# 参考URL
https://hackforplay.xyz/


