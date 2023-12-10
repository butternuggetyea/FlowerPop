using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Dropper dropper;
    // Start is called before the first frame update
    void Start()
    {
        dropper = FindAnyObjectByType<Dropper>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, Vector2.down);
        gameObject.transform.position = new Vector3(dropper.FlowerPos, 6.3f, 0);
       // Debug.DrawRay(gameObject.transform.position, Vector2.down * 10f, Color.magenta, 0.2f);
    }
}
