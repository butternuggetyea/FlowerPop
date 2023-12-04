using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class UtilAmtTracker : MonoBehaviour
{
    public TMP_Text UpgradeTimerTime;

    public TMP_Text BombsHeld;

    public TMP_Text PopsHeld;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpgradeTimerTime.text = "Upgrade Time:" + AutoUpgrader.UpgradeTimerAmt.ToString()+ " S";
        BombsHeld.text = "Bombs Held:" + Dropper.BombsHeld.ToString();
        PopsHeld.text = "Pops Held:" + MouseClick.FlowerPopsHeld.ToString();
       
    }
}
