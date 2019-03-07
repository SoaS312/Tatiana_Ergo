﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFormula : MonoBehaviour
{
    [Header("Shapes")]
    public GameObject formulaLeft;
    public GameObject formulaRight;
    public GameObject formulaUp;
    public GameObject formulaDown;

    [Header("Colors")]
    public Material color1;
    public Material color2;
    public Material color3;
    public Material color4;


    public void Start()
    {
        ShapeFormula.staticShapeFormula.left = false;
        ShapeFormula.staticShapeFormula.right = false;
        ShapeFormula.staticShapeFormula.up = false;
        ShapeFormula.staticShapeFormula.down = false;

        ColorFormula.staticColorFormula.firstColor = false;
        ColorFormula.staticColorFormula.secondColor = false;
        ColorFormula.staticColorFormula.thirdColor = false;
        ColorFormula.staticColorFormula.fourthColor = false;
    }

    public void FixedUpdate()
    {
        TransformShape();

        TransformColor();

    }

    public void TransformColor()
    {
        if (ColorFormula.staticColorFormula.firstColor)
        {
            gameObject.GetComponent<Renderer>().material = color1;
            SaveColor.staticSaveColor.savedMaterial = color1;
        }
        if (ColorFormula.staticColorFormula.secondColor)
        {
            gameObject.GetComponent<Renderer>().material = color2;
            SaveColor.staticSaveColor.savedMaterial = color2;
        }
        if (ColorFormula.staticColorFormula.thirdColor)
        {
            gameObject.GetComponent<Renderer>().material = color3;
            SaveColor.staticSaveColor.savedMaterial = color3;
        }
        if (ColorFormula.staticColorFormula.fourthColor)
        {
            gameObject.GetComponent<Renderer>().material = color4;
            SaveColor.staticSaveColor.savedMaterial = color4;
        }

    }

    public void TransformShape()
    {
        if (ShapeFormula.staticShapeFormula.left)
        {
            this.gameObject.SetActive(false);
            formulaLeft.SetActive(true);
        }

        if (ShapeFormula.staticShapeFormula.right)
        {
            this.gameObject.SetActive(false);
            formulaRight.SetActive(true);
        }

        if (ShapeFormula.staticShapeFormula.up)
        {
            this.gameObject.SetActive(false);
            formulaUp.SetActive(true);
        }

        if (ShapeFormula.staticShapeFormula.down)
        {
            this.gameObject.SetActive(false);
            formulaDown.SetActive(true);
        }
    }
}
