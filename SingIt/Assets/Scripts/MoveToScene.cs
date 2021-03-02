using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoveToScene : MonoBehaviour
{
    public Color OnMouseOverColor = Color.yellow;
    public Color OnMouseClickColor = Color.red;
    public Color OnMouseExitColor = Color.white;
    // Start is called before the first frame update
    public GameObject to;
    void Start()
    {
        
    }
    void OnMouseOver()
    {
            if (Input.GetButtonUp("Fire1"))
            {
                this.transform.parent.gameObject.SetActive(false);
                to.SetActive(true);
            }
        
    }
                // Update is called once per frame
    void Update()
    {
        
    }
}
