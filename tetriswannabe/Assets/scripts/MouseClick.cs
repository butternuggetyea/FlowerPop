using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseClick : MonoBehaviour
{
    public static int FlowerPopsHeld = 0;
    Collider2D MouseCol;
    Transform MouseObj;

    Dropper dropper;
    ShopPoints shopPoints;

    // Start is called before the first frame update
    void Start()
    {
       FlowerPopsHeld = PlayerPrefs.GetInt("FlowerPopsHeld");
        MouseCol = GetComponent<Collider2D>();
        MouseObj = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10f));

        MouseObj.transform.position = worldMousePosition;
        if (Input.GetMouseButtonDown(0)) 
        {
            StartCoroutine(ColliderOnOff());
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.gameObject.layer == 7) { 
        if (FlowerPopsHeld > 0) 
        {
                Debug.Log("Popped");
                Destroy(collision.gameObject);
                FlowerPopsHeld--;
                PlayerPrefs.SetInt("FlowerPopsHeld", FlowerPopsHeld);
            }
        }

        if (collision.gameObject.tag == "BuyBomb") 
        {
            if (ShopPoints.shopPoints >= 10)
            {
                
                Dropper.BombsHeld++;
                PlayerPrefs.SetInt("BombsHeld", Dropper.BombsHeld);
                ShopPoints.shopPoints -= 10;
                Debug.Log(Dropper.BombsHeld);
            }
        }


        if (collision.gameObject.tag == "BuyFlowerPop")
        {
            if (ShopPoints.shopPoints >= 15)
            {
                
                FlowerPopsHeld++;
                PlayerPrefs.SetInt("FlowerPopsHeld", FlowerPopsHeld);
                ShopPoints.shopPoints -= 15;
                Debug.Log(FlowerPopsHeld);
            }
        }

        if (collision.gameObject.tag == "BuyTimeUp") { 
            if (ShopPoints.shopPoints >= 15)
            {
                
                AutoUpgrader.UpgradeTimerAmt += 1.5f;
                ShopPoints.shopPoints -= 15;
                Debug.Log(AutoUpgrader.UpgradeTimerAmt);
            }
        }

        if (collision.gameObject.tag == "GameReturn") 
        {
            Debug.Log("Hit");
            SceneManager.LoadScene(1);
        }


    }

    IEnumerator ColliderOnOff()
    {
        for (int i = 0; i <= 1; i++)
        {
            MouseCol.enabled = true;
            if (i == 1)
            {
                MouseCol.enabled = false;
            }
            yield return new WaitForSecondsRealtime(0.01f);
        }
    }

}
