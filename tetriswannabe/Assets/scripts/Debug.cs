using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Debugs : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("spawned");
            Debug.Log(dropper.next);
       

        }
    }
}
