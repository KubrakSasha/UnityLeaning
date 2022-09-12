using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglesMenu : MonoBehaviour
{
    public GameObject toggleOne;
    public GameObject toggleTwo;
    public GameObject toggleThree;
    public GameObject oneText;
    public GameObject twoText;
    public GameObject threeText;

    public void TooglePrees(GameObject tog) 
    {
        if (tog == toggleOne)
        {
            oneText.SetActive(true);
            twoText.SetActive(false);
            threeText.SetActive(false);
        }

        if (tog == toggleTwo)
        {
            oneText.SetActive(false);
            twoText.SetActive(true);
            threeText.SetActive(false);
        }
        
        if (tog == toggleThree)
        {
            oneText.SetActive(false);
            twoText.SetActive(false);
            threeText.SetActive(true);
        }
    }    
}
