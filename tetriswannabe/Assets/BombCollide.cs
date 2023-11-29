using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BombCollide : MonoBehaviour
{


    BombLogic bombLogic;

    // Start is called before the first frame update
    void Start()
    {
        bombLogic = FindObjectOfType<BombLogic>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Wall")
        {
            bombLogic.explode = true;
        }
    }

}
