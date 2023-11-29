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
        gameObject.transform.position = new Vector3(dropper.FlowerPos, 6.3f, 0);
    }
}
