using UnityEngine;
using System.Collections;

public class SnakeMovement : MonoBehaviour
{

    public float speed = 0.5f;
    public float TurnSpeed = 20f;


    // Update is called once per frame
    void Update()
    {

       transform.localPosition += transform.up * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Rotate(Vector3.left * TurnSpeed * Time.deltaTime);
            transform.localPosition += Vector3.left * speed * Time.deltaTime;
        }

        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.localPosition += Vector3.right * speed * Time.deltaTime;
                transform.Rotate(Vector3.right * TurnSpeed * Time.deltaTime);

            }
        }

        
    }

}