using UnityEngine;
using System.Collections;

public class SnakeBody : MonoBehaviour {

    public float speed = 3f;
    private GameObject target;

    // Use this for initialization
    void Start () {
        target = GameObject.Find("SnakeHead");
	
	}
	
	// Update is called once per frame
	void chase () {
        float movementDistance = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, movementDistance);
    }
}
