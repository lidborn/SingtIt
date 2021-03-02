using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
public class SelectedDecades : MonoBehaviour
{
    public Color OnMouseOverColor = Color.yellow;
    public Color OnMouseClickColor = Color.red;
    public Color OnMouseExitColor = Color.white;
    public List<int> decadesList;
    int nameV;
    bool selected = false;
    bool first = true;
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
        if (!selected)
        {
            GetComponent<TextMeshPro>().color = OnMouseOverColor;
        }
    }
    private void OnMouseDown()
    {
        if (selected)
        {
            GetComponent<TextMeshPro>().color = OnMouseExitColor;
            decadesList[nameV] = -1;
            selected = false;
        }
        else
        {
            GetComponent<TextMeshPro>().color = OnMouseClickColor;
            decadesList[nameV] = nameV;
            selected = true;
        }
    }
    void OnMouseExit()
    {
        if (GetComponent<TextMeshPro>().color != Color.red)
        {
            GetComponent<TextMeshPro>().color = OnMouseExitColor;
        }
    }
    void OnEnable()
    {
        if(first)
        {
            decadesList = GameObject.Find("Data").GetComponent<DataForPlayers>().decadesList;
            nameV = int.Parse(this.name);
            first = false;
            //Debug.Log(nameV);
        }
        if (decadesList[nameV] != -1)
        {
            selected = true;
            GetComponent<TextMeshPro>().color = OnMouseClickColor;
        }
        else
        {

            GetComponent<TextMeshPro>().color = OnMouseExitColor;
        }
    }
    void OnDisable()
    {
        selected = false;



    }
}
