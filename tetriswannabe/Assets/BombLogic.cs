using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BombLogic : MonoBehaviour
{

   [Serialize] public bool explode = false;

    Collider2D BombCollider;

    // Start is called before the first frame update
    void Start()
    {
        BombCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (explode) 
        {
            BombCollider.enabled = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

}
