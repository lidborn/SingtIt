using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MouseOverGraphics : MonoBehaviour
{
    public Color OnMouseOverColor = Color.yellow;
    public Color OnMouseClickColor = Color.red;
    public Color OnMouseExitColor = Color.white;
    bool active = false;
    public bool disableIfMouseExit = true;
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
        if (!active)
        {
            GetComponent<TextMeshPro>().color = OnMouseOverColor;
            if (Input.GetMouseButton(0))
            {
                GetComponent<TextMeshPro>().color = OnMouseClickColor;
                this.active = true;
            }
        }
    }
    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        GetComponent<TextMeshPro>().color = OnMouseExitColor;
        if(disableIfMouseExit)
            this.active = false;
    }
    void OnEnable()
    {
        GetComponent<TextMeshPro>().color = OnMouseExitColor;
    }
    void OnDisable()
    {
        this.active = false;
        GetComponent<TextMeshPro>().color = OnMouseExitColor;
    }
}
