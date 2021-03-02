using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class Quit : MonoBehaviour
{
    public Color OnMouseOverColor = Color.yellow;
    public Color OnMouseClickColor = Color.red;
    public Color OnMouseExitColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseOver()
    {
        GetComponent<TextMeshPro>().color = OnMouseOverColor;
        if (Input.GetButton("Fire1"))
        {
            Application.Quit();
        }
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        GetComponent<TextMeshPro>().color = OnMouseExitColor;
    }
}
