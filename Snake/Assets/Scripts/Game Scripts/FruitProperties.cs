using UnityEngine;
using System.Collections;

public class FruitProperties : MonoBehaviour {

    private GameManager gM;

    void Start()
    {
        GameObject gMObj = GameObject.FindGameObjectWithTag("GameController");
        gM = gMObj.GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            gM.score += 1;
            Destroy(gameObject);
        }
    }

}
