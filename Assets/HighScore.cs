using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{
    private static TMP_Text _text;
    private static int _score;

    private Text txtCom;

    void Awake()
    {
        _text = GetComponent<TMP_Text>();

        if (PlayerPrefs.HasKey("HighScore"))
        {
            SCORE = PlayerPrefs.GetInt("HighScore");
        }
        PlayerPrefs.SetInt("HighScore", SCORE);
    }

    public static int SCORE
    {
        get { return _score; }
        private set
        {
            _score = value;
            PlayerPrefs.SetInt("HighScore", _score);
            if (_text != null)
                _text.text = "High Score: "+_score.ToString("#,0");
        }
    }

    public static void TrySetHighScore(int score)
    {
        if (score <= SCORE) return;
        SCORE = score;
    }
    [Tooltip("Check this box to reset the High Score")]
    public bool ResetHighScore =  false;

    void OnDrawGizmos()
    {
        if (ResetHighScore)
        {
            ResetHighScore = false;
            PlayerPrefs.SetInt("HighScore", 1000);
            Debug.LogWarning("High Score reset to 1,000");
        }
    }
}
