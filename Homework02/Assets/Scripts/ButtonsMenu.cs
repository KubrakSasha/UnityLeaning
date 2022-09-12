using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsMenu : MonoBehaviour
{
    [SerializeField]
    internal GameObject buttonOne;
    public GameObject buttonTwo;    
    public GameObject buttonDisable;
    public GameObject oneText;
    public GameObject twoText;
    public void ButtonPressed(GameObject but) 
    {
        if (but == buttonOne)
        {
            twoText.SetActive(false);
            oneText.SetActive(true);
        }
        if (but == buttonTwo)
        {
            oneText.SetActive(false);
            twoText.SetActive(true);
        }
        if (but == buttonDisable) 
        {
            oneText.SetActive(false);
            twoText.SetActive(false);
            buttonOne.GetComponent<Button>().enabled = false;
            buttonTwo.GetComponent<Button>().enabled = false;         
            buttonDisable.GetComponent<Button>().enabled = false;
        }
    }
}
