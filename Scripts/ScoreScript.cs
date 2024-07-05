using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;
    [SerializeField] private TextMeshProUGUI _currentScore;
    private int _score;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _currentScore.text = _score.ToString();
    }

    public void UpdateScore()
    {
        _score++;
        _currentScore.text = _score.ToString();

    }
}
