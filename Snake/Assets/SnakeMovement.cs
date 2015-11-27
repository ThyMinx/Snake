using UnityEngine;
using System.Collections;

public class SnakeMovement : MonoBehaviour
{

    public float speed = 0.5f;
    public float TurnSpeed = 10f;


    // Update is called once per frame
    void Update()
    {

        transform.localPosition += transform.up * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
       
            }
        }

        
    }

}