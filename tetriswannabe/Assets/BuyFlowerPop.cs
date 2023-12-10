using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuyFlowerPop : MonoBehaviour
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
        if (ShopPoints.shopPoints >= 15)
        {

            MouseClick.FlowerPopsHeld++;
            PlayerPrefs.SetInt("FlowerPopsHeld", MouseClick.FlowerPopsHeld);
            ShopPoints.shopPoints -= 15;
            Debug.Log(MouseClick.FlowerPopsHeld);
            PlayerPrefs.SetInt("shopPoints", ShopPoints.shopPoints);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "mouse")
        {
            Info.text = "Buy Flower Pop: 1 for 15 points";
        }
    }
}
