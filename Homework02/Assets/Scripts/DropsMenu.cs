using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropsMenu : MonoBehaviour
{    
    public GameObject textA;
    public GameObject textB;
    public GameObject textC;
    public GameObject textD;
    public void DropChoice(GameObject drop) 
    {
        int a = drop.GetComponent<Dropdown>().value;
        if (a == 0)
        {
            textA.SetActive(true);
            textB.SetActive(false);
            textC.SetActive(false);
            textD.SetActive(false);            
        }
        if (a == 1)
        {
            textA.SetActive(false);
            textB.SetActive(true);
            textC.SetActive(false);
            textD.SetActive(false);
        }
        if (a == 2)
        {
            textA.SetActive(false);
            textB.SetActive(false);
            textC.SetActive(true);
            textD.SetActive(false);
        }
        if (a == 3)
        {
            textA.SetActive(false);
            textB.SetActive(false);
            textC.SetActive(false);
            textD.SetActive(true);
        }
    }    
}
