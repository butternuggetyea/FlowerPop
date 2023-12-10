using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuyBomb : MonoBehaviour
{
    public TMP_Text Info;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {

        if (ShopPoints.shopPoints >= 10)
        {

            Dropper.BombsHeld = Dropper.BombsHeld + 3;
            PlayerPrefs.SetInt("BombsHeld", Dropper.BombsHeld);
            ShopPoints.shopPoints -= 10;
            Debug.Log(Dropper.BombsHeld);
            PlayerPrefs.SetInt("shopPoints", ShopPoints.shopPoints);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "mouse")
        {
          Info.text = "Buy Bombs: 3 for 10 points";
        }
    }
}
