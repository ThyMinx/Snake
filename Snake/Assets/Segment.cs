using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Segment : MonoBehaviour
{
    public class plot
    {
        public int x, y;
    }
    public enum directions
    {
        LEFT,
        RIGHT,
        DOWN,
        UP
    }
    plot coords;

    List<Transform> tail = new List<Transform>();

    public bool ate = false;
    public GameObject tailPrefab;
    directions dir = directions.LEFT;
    void Start()
    {
        coords = new plot();
        InvokeRepeating("move", 1, 0.5f);
    }

    void Update()
    {

        //move
        if (Input.GetKeyDown(KeyCode.LeftArrow)) dir = directions.LEFT;
        if (Input.GetKeyDown(KeyCode.RightArrow)) dir = directions.RIGHT;
        if (Input.GetKeyDown(KeyCode.UpArrow)) dir = directions.UP;
        if (Input.GetKeyDown(KeyCode.DownArrow)) dir = directions.DOWN;


    }

    public void move()
    {
        //current
        Vector3 pos = transform.position;
        switch (dir)
        {
            case directions.LEFT:
                coords.x -= 1;
                transform.Translate(new Vector3(-1, 0, 0), Space.Self);
                break;
            case directions.RIGHT:
                coords.x += 1;
                transform.Translate(new Vector3(1, 0, 0), Space.Self);
                break;
            case directions.DOWN:
                coords.y -= 1;
                transform.Translate(new Vector3(0, -1, 0), Space.Self);
                break;
            case directions.UP:
                coords.y += 1;
                transform.Translate(new Vector3(0, 1, 0), Space.Self);
                break;
            default:
                break;
        }
        Debug.Log("x" + coords.x + "y" + coords.y);
        //adding to tail
        if (ate)
        {
            GameObject g = (GameObject)Instantiate(tailPrefab, pos, Quaternion.identity);

            tail.Insert(0, g.transform);

            ate = false;
        }

        //arange list so that last goes to "gap"
        if (tail.Count > 0)
        {
            tail.Last().position = pos;

            tail.Insert(0, tail.Last());
            tail.RemoveAt(tail.Count - 1);
        }
    }

}

