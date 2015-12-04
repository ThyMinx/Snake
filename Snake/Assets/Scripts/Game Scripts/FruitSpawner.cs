using UnityEngine;
using System.Collections;

public class FruitSpawner : MonoBehaviour {

    public float waitTime = 4f;
    public Transform[] spawnpoint;
    public GameObject fruit;

    void Start()
    {
        InvokeRepeating("Spawner", 2f, waitTime);
    }

    void Spawner()
    {
        int fruitIndex = Random.Range(0, spawnpoint.Length);
        Instantiate(fruit, spawnpoint[fruitIndex].position, spawnpoint[fruitIndex].rotation);
    }

}
