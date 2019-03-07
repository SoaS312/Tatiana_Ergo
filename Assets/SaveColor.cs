using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveColor : MonoBehaviour
{
    public static SaveColor staticSaveColor;
    public Material savedMaterial;

    private void Awake()
    {
        staticSaveColor = this;
    }

}
