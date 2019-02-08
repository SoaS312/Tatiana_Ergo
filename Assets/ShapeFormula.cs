using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeFormula : MonoBehaviour
{
    public static ShapeFormula staticShapeFormula; 
    public bool left = false;
    public bool right = false;
    public bool up = false;
    public bool down = false;

    public void Awake()
    {
        staticShapeFormula = this;
    }

    public void FixedUpdate()
    {

        KeysDown();

        KeysUp();
    }

    public void KeysDown()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !left)
        {
            left = !left;
        } else if (Input.GetKeyDown(KeyCode.RightArrow) && !right)
        {
            right = !right;
        } else if (Input.GetKeyDown(KeyCode.UpArrow) && !up)
        {
            up = !up;
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && !down)
        {
            down = !down;
        }
    }

    public void KeysUp()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow) && left)
        {
            left = !left;
        } else if (Input.GetKeyUp(KeyCode.RightArrow) && right)
        {
            right = !right;
        } else if (Input.GetKeyUp(KeyCode.UpArrow) && up)
        {
            up = !up;
        } else if (Input.GetKeyUp(KeyCode.DownArrow) && down)
        {
            down = !down;
        }
    }
}
