using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectifStart : MonoBehaviour
{
    public Material selectedColor;
    public List<Material> Colors;
    public int colorIndex = 0;
    public int shapeIndex = 0;
    public List<GameObject> ChildrenShapes;
    public GameObject selectedShape;

    void Awake()
    {
        ChooseObjectifShape();
        ChooseObjectifColor();
    }

    private void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            selectedShape.SetActive(false);
            ChooseObjectifShape();
            ChooseObjectifColor();
        }
    }

    private void ChooseObjectifShape()
    {
        shapeIndex = Random.Range(0, ChildrenShapes.Count);
        selectedShape = ChildrenShapes[shapeIndex];
        selectedShape.SetActive(true);
    }

    private void ChooseObjectifColor()
    {
        colorIndex = Random.Range(0, Colors.Count);
        selectedColor = Colors[colorIndex];
        selectedShape.GetComponent<Renderer>().material = selectedColor;
    }






}
