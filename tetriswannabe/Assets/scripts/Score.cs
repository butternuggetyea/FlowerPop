using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text score;

    public TMP_Text HighScoreTXT;

    [SerializeField] public static int HighScore;

    [SerializeField] public static int TotalScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TotalScore>HighScore) 
        {
            HighScore = TotalScore;
        }
        score.text = "Current Score:" + TotalScore.ToString();
        HighScoreTXT.text = "High Score:" + HighScore.ToString();
    }
}
