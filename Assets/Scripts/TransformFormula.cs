using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFormula : MonoBehaviour
{
    public GameObject formulaLeft;
    public GameObject formulaRight;
    public GameObject formulaUp;
    public GameObject formulaDown;

    public void Start()
    {
        ShapeFormula.staticShapeFormula.left = false;
        ShapeFormula.staticShapeFormula.right = false;
        ShapeFormula.staticShapeFormula.up = false;
        ShapeFormula.staticShapeFormula.down = false;
    }

    public void LateUpdate()
    {
        TransformShape();
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
