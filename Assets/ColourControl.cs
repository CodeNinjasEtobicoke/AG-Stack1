using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourControl : MonoBehaviour
{
    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void ChangeColor()
    {
        mat.color = new Color(0f, 0f, 0f);
    }
}
