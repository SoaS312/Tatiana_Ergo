using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomColor : MonoBehaviour
{

    public Material selectedColor;
    public List<Material> Colors;
    public int colorIndex = 0;

    public void OnEnable()
    {
        if(gameObject.activeInHierarchy)
        RandomColor();
    }

    void RandomColor()
        {
            colorIndex = Random.Range(0, Colors.Count);
            selectedColor = Colors[colorIndex];
            gameObject.GetComponent<Renderer>().material = selectedColor;
        }
}
