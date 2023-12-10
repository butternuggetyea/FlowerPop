using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScreen : MonoBehaviour
{
    public GameObject HOWTO;
    private bool onOff = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(onOff);
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (onOff == false)
            {
                HOWTO.SetActive(true);
                onOff = true;
            }

            else if(onOff == true) 
            {
                HOWTO.SetActive(false);
                onOff = false;
            }

        }
    }
}
