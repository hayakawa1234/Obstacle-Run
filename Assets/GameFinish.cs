using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
{
    private int bestScore;
    public Text finishTime;
    public Text bestTime;
    public GameObject finishUI;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("BestScore"))
        {
            bestScore = PlayerPrefs.GetInt("BestScore");
        }
        else
        {
            bestScore = 999;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Goal.goal == true)
        {
            finishUI.SetActive(true);
            int score = Mathf.FloorToInt(Timer.time);
            finishTime.text = "FinishTime = " + score;
            bestTime.text = "BestTime = " + bestScore;
            if(bestScore > score)
            {
                PlayerPrefs.SetInt("BestScore", score);
            }
        }
    }
    public void OnRetry()
    {
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name);
    }
    
}
