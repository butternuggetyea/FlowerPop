using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text score;

    public TMP_Text HighScoreTXT;

    public TMP_Text DropperTXT;

    public TMP_Text MouseClickTxt;

    Dropper dropper;

    MouseClick mouseClick;

    public static int HighScore;
    public static int ActiveScore;
    // Start is called before the first frame update
    void Start()
    {
       
        ActiveScore = 0;
        HighScore = PlayerPrefs.GetInt("HighScore");
        //HighScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ActiveScore > HighScore) 
        {
            HighScore = ActiveScore;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }
        score.text = "Current Score:" + ActiveScore.ToString();
        HighScoreTXT.text = "High Score:" + HighScore.ToString();

        if (MouseClick.FlowerPopsHeld > 0) { }

        if (Dropper.BombsHeld > 0) { }

    }
}
