using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MouseClick : MonoBehaviour
{
    public static int FlowerPopsHeld = 1;
    Collider2D MouseCol;
    Transform MouseObj;

    private bool htp = true;
    public TMP_Text HTP;
    private int FirstRun;

    Dropper dropper;
    ShopPoints shopPoints;

    // Start is called before the first frame update
    void Start()
    {
        FirstRun = PlayerPrefs.GetInt("FirstRun");
        if (FirstRun == 0)
        {
            PlayerPrefs.SetInt("FlowerPopsHeld", FlowerPopsHeld);
            FirstRun = 1;
            PlayerPrefs.SetInt("FirstRun", FirstRun);
        }

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

        if (collision.gameObject.layer == 7)
        {
            if (FlowerPopsHeld > 0)
            {
                Debug.Log("Popped");
                Destroy(collision.gameObject);
                FlowerPopsHeld--;
                PlayerPrefs.SetInt("FlowerPopsHeld", FlowerPopsHeld);
            }
        }


        if (collision.gameObject.tag == "HTP") 
        {
            if (htp)
            {
                HTP.text = "Dropper Movement: Keys  A,D\r\nDrop Object: Key Spacebar \r\nDrop Bomb: Key B\r\nPop Flower: Mouse Left Click On Object Of Choice\r\n\r\nAuto Upgrade: The objects you place will slowly auto upgrade yeilding no points for the combine while allowing other higher combinations.\r\n\r\nFail: Careful, dont over fill your basket, if you do and a object falls over the side, Game Over. \r\n\r\nGoal: Combine two of the same objects to get points and create a bigger object. Use the points in the shop to buy upgrades. \r\n ";
            }
            else if(htp == false){ HTP.text = " "; }
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
