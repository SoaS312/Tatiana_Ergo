using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseColor : MonoBehaviour
{
    public Material selectedColor;
    public List<Material> Colors;
    public int colorIndex = 0;

    public bool isObjectif;
    
    void Start()
    {
        ChooseColorShape();
    }

    public void ChooseColorShape()
    {
        colorIndex = Random.Range(0, Colors.Count);
        selectedColor = Colors[colorIndex];
        gameObject.GetComponent<Renderer>().material = selectedColor;
    }
}
