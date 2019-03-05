using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFormula : MonoBehaviour
{ 
public static ColorFormula staticColorFormula;
public bool firstColor = false;
public bool secondColor = false;
public bool thirdColor = false;
public bool fourthColor = false;

public void Awake()
{
        staticColorFormula = this;
}

public void FixedUpdate()
{
    KeysDown();

    KeysUp();
}

public void KeysDown()
{
    if (Input.GetKeyDown(KeyCode.Alpha1) && !firstColor)
    {
        firstColor = !firstColor;
    }
    else if (Input.GetKeyDown(KeyCode.Alpha2) && !secondColor)
    {
        secondColor = !secondColor;
    }
    else if (Input.GetKeyDown(KeyCode.Alpha3) && !thirdColor)
    {
        thirdColor = !thirdColor;
    }
    else if (Input.GetKeyDown(KeyCode.Alpha4) && !fourthColor)
    {
        fourthColor = !fourthColor;
    }
}

public void KeysUp()
{
    if (Input.GetKeyUp(KeyCode.Alpha1) && firstColor)
    {
        firstColor = !firstColor;
    }
    else if (Input.GetKeyUp(KeyCode.Alpha2) && secondColor)
    {
        secondColor = !secondColor;
    }
    else if (Input.GetKeyUp(KeyCode.Alpha3) && thirdColor)
    {
        thirdColor = !thirdColor;
    }
    else if (Input.GetKeyUp(KeyCode.Alpha4) && fourthColor)
    {
        fourthColor = !fourthColor;
    }
}
}
