using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower2 : MonoBehaviour
{
    Score score;
    private static List<GameObject> Flowers;
    public bool spawnNewBall;
    private float ObjX, ObjY, ObjZ;
    // Start is called before the first frame update
    void Start()
    {
        spawnNewBall = true;
        Flowers = new List<GameObject>(Resources.LoadAll<GameObject>("Flowers"));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)

    {

        if (collision.gameObject.tag == "Flower2")
        {

            if (spawnNewBall)
            {
                collision.gameObject.GetComponent<Flower2>().spawnNewBall = false;

            }



            ObjX = collision.gameObject.transform.position.x;
            ObjY = collision.gameObject.transform.position.y;
            ObjZ = collision.gameObject.transform.position.z;

            StartCoroutine(RespawnBall());


        }
    }

    IEnumerator RespawnBall()
    {
        if (spawnNewBall)
        {
            audioscript.playSound = true;
            Score.ActiveScore += 50;
            Instantiate(Flowers[2], new Vector3(ObjX, ObjY, 0), Quaternion.Euler(0, 0, 0));
        }
        Destroy(gameObject);
        yield return null;
    }
}
