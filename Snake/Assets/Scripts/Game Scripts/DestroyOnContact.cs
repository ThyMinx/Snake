using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Boundary" || col.tag == "Player")
        {
            Destroy(gameObject);
        }
        else
        {
            return;
        }
    }

}
