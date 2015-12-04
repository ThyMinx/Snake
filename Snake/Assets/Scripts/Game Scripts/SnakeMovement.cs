using UnityEngine;
using System.Collections;

public class SnakeMovement : MonoBehaviour
{

    public float speed = 0.5f;
    //  public float TurnSpeed = 20f;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition += Vector3.left * speed * Time.deltaTime;
        }

        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.localPosition += Vector3.right * speed * Time.deltaTime;

            }

            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    transform.localPosition += Vector3.up * speed * Time.deltaTime;

                }
            }

            {
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    transform.localPosition += Vector3.down * speed * Time.deltaTime;

                }


            }

        }
    }
}