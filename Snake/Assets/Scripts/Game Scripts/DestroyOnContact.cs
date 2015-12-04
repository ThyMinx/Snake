using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

    private GameManager gM;

    void Start()
    {
        GameObject gMObj = GameObject.FindGameObjectWithTag("GameController");
        gM = gMObj.GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Boundary" || col.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (col.tag == "Fruit")
        {
            gM.score += 1;
        }
    }

}
