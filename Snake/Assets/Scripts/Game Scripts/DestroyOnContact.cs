using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

    public GameManager gM;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Boundary" || col.tag == "Player")
        {
            gM.endGame = true;
            Destroy(gameObject);
        }
    }

}
