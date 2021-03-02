using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Options : MonoBehaviour
{
    public GameObject optionsScene;
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
            this.transform.parent.gameObject.SetActive(false);
            GetComponent<TextMeshPro>().color = OnMouseClickColor;
            optionsScene.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        GetComponent<TextMeshPro>().color = OnMouseExitColor;
    }
    void OnEnable()
    {
        GetComponent<TextMeshPro>().color = OnMouseExitColor;
    }
}
