using UnityEngine;
using System.Collections;

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

    void Start()
    {
        coords = new plot();
    }

    void Update()
    {
        //current
        //move
        if (Input.GetKeyDown(KeyCode.LeftArrow)) move(directions.LEFT);
        if (Input.GetKeyDown(KeyCode.RightArrow)) move(directions.RIGHT);
        if (Input.GetKeyDown(KeyCode.UpArrow)) move(directions.UP);
        if (Input.GetKeyDown(KeyCode.DownArrow)) move(directions.DOWN);

        //arange list so that last goes to "gap"
    }

    public void move(directions p_dir)
    {

        switch (p_dir)
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
    }

}

