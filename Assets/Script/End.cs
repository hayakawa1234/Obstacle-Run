using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.V)) //Vボタンを押した場合
		{
			SceneManager.LoadScene("TittleScene");//タイトルシーンをロードする
		}

	}
}
