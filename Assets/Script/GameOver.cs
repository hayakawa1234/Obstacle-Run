﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする

public class GameOver : MonoBehaviour
{
	//シーンの遷移処理
	void Update()
	{
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.C)) //マウス左クリック,Bボタンを押した場合
		{
			SceneManager.LoadScene("main");//タイトルシーンをロードする
		}

	}
}