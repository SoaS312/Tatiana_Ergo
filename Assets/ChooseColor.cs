using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseColor : MonoBehaviour
{
    public Material selectedColor;
    public List<Material> Colors;
    public int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range(0, Colors.Count+1);
        Debug.Log(index);
        selectedColor = Colors[index];
        gameObject.GetComponent<Renderer>().material = selectedColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
