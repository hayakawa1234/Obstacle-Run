using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// 1.UIシステムを利用するときに利用（今回でいう「Text」）
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    // 2.時間経過を示す「time」変数
    public static float time;

    // Use this for initialization
    void Start()
    {

        // 3.ゲーム開始時は「time」は「0」
        time = 0;

    }

    // Update is called once per frame
    void Update()
    {

        // 4.まだゴールをしてなかったら
        if (Goal.goal == false)
        {
            // 5.経過時間を追加
            time = time + Time.deltaTime;
        }

        if (Goal.goal == true)
        {
            SceneManager.LoadScene("End");
        }

        // 6.小数点以下を切り捨てる
        int t = Mathf.FloorToInt(time);

        // 7.「Text」Componentを取得して、「uiText」に格納
        Text uiText = GetComponent<Text>();

        // 8.テキストを編集
        uiText.text = "Time = " + t;
    }
}