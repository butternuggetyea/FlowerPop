using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Random = UnityEngine.Random;
using Debug = UnityEngine.Debug;

public class Dropper : MonoBehaviour
{
    deleteSelf DeleteSelf;
    private static List<GameObject> Flowers;
    private static List<GameObject> FlowerIcon;
    public float FlowerPos = 0;
    public int now;
    public int next = 0;

    private bool CanDrop = true;

    public static int BombsHeld = 0;

    public GameObject Bomb;

    //private static List<GameObject> UsingNext;
    // Start is called before the first frame update
    void Start()
    {
        BombsHeld = PlayerPrefs.GetInt("BombsHeld");
        FlowerIcon = new List<GameObject>(Resources.LoadAll<GameObject>("FlowerIcon"));
        Flowers = new List<GameObject>(Resources.LoadAll<GameObject>("Flowers"));
        // UsingNext = new List<GameObject>();
        Instantiate(FlowerIcon[next], new Vector3(9.5f, 4.9f, 0), Quaternion.Euler(0, 0, 0));

    }

    // Update is called once per frame
    void Update()
    {
      
        //Debug.Log(next);
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (CanDrop)
            {
                CanDrop = false;
                StartCoroutine(Next());
                FlowerSpawn();
                
            }

        }

        if (Input.GetKey(KeyCode.D)) 
        {
            if (FlowerPos <= 3.3)
            {
                FlowerPos += 0.005f;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (FlowerPos >= -3.3)
            {
                FlowerPos -= 0.005f;
            }
        }

        if (Input.GetKeyDown(KeyCode.B)) 
        {
            if (BombsHeld > 0)
            {
                Instantiate(Bomb, new Vector3(FlowerPos, 4.9f, 0), Quaternion.Euler(0, 0, 0));
                BombsHeld--;
                PlayerPrefs.SetInt("BombsHeld", BombsHeld);
            }
        }

    }

    void FlowerSpawn()
    {




        DeleteSelf = FindAnyObjectByType<deleteSelf>();
        
        Instantiate(Flowers[now], new Vector3(FlowerPos, 4.75f,0), Quaternion.Euler(0, 0, 0));

        int RandomFlower = Random.Range(0, 4);
        next = RandomFlower;
        DeleteSelf.DeleteSelf = true;
        Instantiate(FlowerIcon[next], new Vector3(9.5f, 4.9f, 0), Quaternion.Euler(0, 0, 0));

    }

    IEnumerator Next()
    {
        for (int i = 0; i <=1; i++)
        {

            if (i == 1)
            {
                CanDrop = true;
                now = next;
            }
            yield return new WaitForSeconds(0.5f);
        }

    }

}
