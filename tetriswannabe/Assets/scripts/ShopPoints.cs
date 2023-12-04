using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopPoints : MonoBehaviour
{
    Score score;

    public TMP_Text Points;

    public static int shopPoints;
    // Start is called before the first frame update
    void Start()
    {
      shopPoints = PlayerPrefs.GetInt("shopPoints");
        shopPoints += (Score.ActiveScore / 1000);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("shopPoints", shopPoints);
        Points.text = "Shop Points: " + shopPoints.ToString();
    }
}
