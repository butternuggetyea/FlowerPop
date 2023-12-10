using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuyTimerup : MonoBehaviour
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

            AutoUpgrader.UpgradeTimerAmt += 2f;
            ShopPoints.shopPoints -= 15;
            Debug.Log(AutoUpgrader.UpgradeTimerAmt);
            PlayerPrefs.SetInt("shopPoints", ShopPoints.shopPoints);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "mouse") {
            Info.text = "Increase Auto Upgrade Timer: Add 2 seconds"; }
    }
}
