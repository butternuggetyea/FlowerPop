using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Flower1 : MonoBehaviour
{
    Score score;
    private static List<GameObject> Flowers;
    public bool spawnNewBall;
    private float ObjX, ObjY, ObjZ;
    // Start is called before the first frame update
    void Start()
    {
        score = FindFirstObjectByType<Score>();
        spawnNewBall = true;
        Flowers = new List<GameObject>(Resources.LoadAll<GameObject>("Flowers"));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)

    {

        if (collision.gameObject.tag == "Flower1")
        {

            if (spawnNewBall)
            {
                collision.gameObject.GetComponent<Flower1>().spawnNewBall = false;

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
            Score.ActiveScore += 25;
            Instantiate(Flowers[1], new Vector3(ObjX, ObjY, 0), Quaternion.Euler(0, 0, 0));
        }
        Destroy(gameObject);
        yield return null;
    }

}
