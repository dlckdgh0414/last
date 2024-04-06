using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour
{
    public Text currentScoreUI;
    public int currentScore;

    public Text BestScoreUI;
    public int BestScore;
    public static ScoreManger Instanc = null;

    private void Awake()
    {
         if(Instanc == null)
        {
            Instanc = this;
        }
    }

    void Start()
    {
        BestScore = PlayerPrefs.GetInt("최고 점수", 0);
        BestScoreUI.text = "최고 점수" + BestScore;
    }
    public void SetScore(int value)
    {
        currentScore = value;
        currentScoreUI.text = $"현재 점수 : {currentScore}";
        if(currentScore > BestScore)
        {
            BestScore = currentScore;
            BestScoreUI.text = "최고 점수" + BestScore;
            PlayerPrefs.SetInt("최고점수", BestScore);
        }
    }
    public int GetScore()
    {
        return currentScore;
    }
}
