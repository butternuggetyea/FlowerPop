using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text score;

    public TMP_Text HighScoreTXT;

    [SerializeField] public static int HighScore;

    [SerializeField] public static int ActiveScore;
    // Start is called before the first frame update
    void Start()
    {
        ActiveScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ActiveScore > HighScore) 
        {
            HighScore = ActiveScore;
        }
        score.text = "Current Score:" + ActiveScore.ToString();
        HighScoreTXT.text = "High Score:" + HighScore.ToString();
    }
}
