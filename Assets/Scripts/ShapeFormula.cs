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
    public bool canRelease = true;

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
        if (!canRelease)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                left = true;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                right = true;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                up = true;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                down = true;
            }
        }
    }

    public void KeysUp()
    {
        if (!Input.anyKey)
        {
            left = false;
            right = false;
            up = false;
            down = false;
        }
    }
}
