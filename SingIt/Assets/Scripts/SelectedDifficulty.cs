using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SelectedDifficulty : MonoBehaviour
{
    public Color OnMouseOverColor = Color.yellow;
    public Color OnMouseClickColor = Color.red;
    public Color OnMouseExitColor = Color.white;
    public List<GameObject> difficulties;
    bool selected = false;
    bool mouseOver = false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 11; i++)
        {
            difficulties.Add(GameObject.Find(i.ToString()));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!selected && !mouseOver)
        {
            GetComponent<TextMeshPro>().color = OnMouseExitColor;
        }

    }
    void OnMouseOver()
    {
        if (GetComponent<TextMeshPro>().color != Color.red)
        {
            GetComponent<TextMeshPro>().color = OnMouseOverColor;
            mouseOver = true;
            if (Input.GetButton("Fire1"))
            {
                foreach (var item in difficulties)
                {
                    SelectedDifficulty stuff = item.GetComponent<SelectedDifficulty>();
                    stuff.selected = false;
                }
                selected = true;
                GameObject.Find("Data").GetComponent<DataForPlayers>().difficulty = int.Parse(this.name);

                GetComponent<TextMeshPro>().color = OnMouseClickColor;
            }
        }
    }
    void OnMouseExit()
    {
        mouseOver = false;
        if (GetComponent<TextMeshPro>().color != Color.red)
        {
            GetComponent<TextMeshPro>().color = OnMouseExitColor;
        }
    }
    void OnEnable()
    {


        GetComponent<TextMeshPro>().color = OnMouseExitColor;
        int test = GameObject.Find("Data").GetComponent<DataForPlayers>().difficulty;

        foreach (var item in difficulties)
        {
            if(test == int.Parse(this.name))
            {
                selected = true;
                GetComponent<TextMeshPro>().color = OnMouseClickColor;
            }

        }
    }
    private void OnDisable()
    {
        foreach (var item in difficulties)
        {
                selected = false;
        }
    }
}
