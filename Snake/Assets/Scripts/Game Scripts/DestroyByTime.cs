using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

    public float wait = 10f;

    void Update()
    {
        wait -= Time.deltaTime;

        if (wait <= 0)
        {
            Destroy(gameObject);
        }
    }

}
