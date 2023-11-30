using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoUpgrader : MonoBehaviour
{
    public float UpgradeTimerAmt = 60f;
    public int FlowerUpNum;
    private static List<GameObject> Flowers;
    // Start is called before the first frame update
    void Start()
    {
        Flowers = new List<GameObject>(Resources.LoadAll<GameObject>("Flowers"));
        StartCoroutine(UpgradeTimer());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator UpgradeTimer()
    {
        for (int i = 0; i <= 1; i++)
        {
            Debug.Log(i);
            if (i == 1)
            {
                Instantiate(Flowers[FlowerUpNum], new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.Euler(0, 0, 0)) ;
                Destroy(gameObject);
            }
            yield return new WaitForSeconds(UpgradeTimerAmt);
        }
    }

}
