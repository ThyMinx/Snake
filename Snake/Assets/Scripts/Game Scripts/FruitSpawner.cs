using UnityEngine;
using System.Collections;

public class FruitSpawner : MonoBehaviour {

    //public float waitTime = 4f;
    public Transform[] spawnpoint;
    public GameObject fruit;
    public GameManager gM;

    void Start()
    {
        Invoke("Spawner", 0);
    }

    void Spawner()
    {
        if (!gM.paused)
        {
            int fruitIndex = Random.Range(0, spawnpoint.Length);
            Instantiate(fruit, spawnpoint[fruitIndex].position, spawnpoint[fruitIndex].rotation);
        }
        else
        {
            return;
        }
    }

}
