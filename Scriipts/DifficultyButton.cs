using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private GameManager gameManager;
    private Button button;

    public int difficulty;

    void Start()
    {
        button = GetComponent<Button>();

        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        button.onClick.AddListener(SetDifficulty);
    }

    void Update()
    {
        
    }

    public void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked ");
        gameManager.StartGame(difficulty);
    }
}
