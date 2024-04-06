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
        BestScore = PlayerPrefs.GetInt("�ְ� ����", 0);
        BestScoreUI.text = "�ְ� ����" + BestScore;
    }
    public void SetScore(int value)
    {
        currentScore = value;
        currentScoreUI.text = $"���� ���� : {currentScore}";
        if(currentScore > BestScore)
        {
            BestScore = currentScore;
            BestScoreUI.text = "�ְ� ����" + BestScore;
            PlayerPrefs.SetInt("�ְ�����", BestScore);
        }
    }
    public int GetScore()
    {
        return currentScore;
    }
}
