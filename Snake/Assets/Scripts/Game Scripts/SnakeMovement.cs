using UnityEngine;
using System.Collections;

public class SnakeMovement : MonoBehaviour
{

    public float speed = 0.5f;
    private bool moving = false;
    //  public float TurnSpeed = 20f;


    // Update is called once per frame
    void Update()
    {
        moving = false;
        if (Input.GetKey(KeyCode.LeftArrow));
        {
            if (moving == true);
            transform.localPosition += Vector3.left * speed * Time.deltaTime;
            moving = true;
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