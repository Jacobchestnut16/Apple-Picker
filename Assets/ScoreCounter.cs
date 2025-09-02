using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int score = 0;
    private TMP_Text scoreText;
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
    }

    void Update()
    {
        scoreText.text = score.ToString("#,0");
    }
}
