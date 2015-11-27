using UnityEngine;
using System.Collections;

public class SnakeMovement : MonoBehaviour
{

    public float speed = 1.75f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}

