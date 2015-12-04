using UnityEngine;
using System.Collections;

public class FruitProperties : MonoBehaviour {

    private GameManager gM;
    private GameObject spawner;
    public GameObject fruit;

    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner");
        GameObject gMObj = GameObject.FindGameObjectWithTag("GameController");
        gM = gMObj.GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            gM.score += 1;
            int yRnd = Random.Range(-4, 4);
            int xRnd = Random.Range(-5, 5);
            Vector3 pos = new Vector3(xRnd, yRnd);
            Quaternion rot = new Quaternion(0,0,0,0);
            Instantiate(fruit, pos, rot);
            Destroy(gameObject);
        }
    }

}
