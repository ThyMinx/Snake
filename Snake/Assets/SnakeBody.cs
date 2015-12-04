using UnityEngine;
using System.Collections;

public class SnakeBody : MonoBehaviour {

    public float speed = 3f;
    public Transform Target;

    //private GameObject target;

    // Use this for initialization
    void Start () {
        Target = GameObject.FindGameObjectWithTag("Player").transform;

	
	}
	
	// Update is called once per frame
	void update () {

        Vector3 vectorToTarget = Target.transform.position - transform.position;
        transform.position += vectorToTarget.normalized * speed * Time.deltaTime;
	}

}
