using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class SavePref : MonoBehaviour
{
    int scoreText;
    public TextMeshProUGUI totalScoreText;
    void Start()
    {
        scoreText = 0;

        SaveScore();
        LoadScore();
    }

    void Update()
    {
        
    }

    private void SaveScore()
    {
        PlayerPrefs.SetInt("score", scoreText);
    }

    private void LoadScore()
    {
        scoreText = PlayerPrefs.GetInt("score");

        totalScoreText.text = "score:" + scoreText;
    }
}
