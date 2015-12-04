using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class FruitProperties : MonoBehaviour {

    private GameManager gM;    
    private GameObject gMObj;
    private GameObject spawner;
    private GameObject player;
    private Segment segment;

    public GameObject fruit;

    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner");
        player = GameObject.FindGameObjectWithTag("Player");
        gMObj = GameObject.FindGameObjectWithTag("GameController");
        gM = gMObj.GetComponent<GameManager>();
        segment = player.GetComponent<Segment>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            gM.score += 1;
            segment.ate = true;
            int yRnd = Random.Range(-4, 4);
            int xRnd = Random.Range(-5, 5);
            Vector3 pos = new Vector3(xRnd, yRnd);
            Quaternion rot = new Quaternion(0,0,0,0);
            Instantiate(fruit, pos, rot);
            Destroy(gameObject);
        }
    }

}
