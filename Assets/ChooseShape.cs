using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseShape : MonoBehaviour
{
    public GameObject selectedShape;
    public List<GameObject> Shapes;
    public int shapeIndex = 0;

    void Start()
    {
        ChooseShapeFunction();

    }

    private void ChooseShapeFunction()
    {
        shapeIndex = Random.Range(0, Shapes.Count);
        selectedShape = Shapes[shapeIndex];
        selectedShape.SetActive(true);
    }
}
