using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    [SerializeField]
    GameObject redButton;
    [SerializeField]
    GameObject blueButton;
    [SerializeField]
    GameObject yellowButton;
    [SerializeField]
    GameObject greenButton;
    [SerializeField]
    GameObject[] airplanes;
    void Start()
    {
        for (int i = 0; i < airplanes.Length; i++)
        {
            airplanes[0].SetActive(true);
            airplanes[i].SetActive(false);
        }
    }
    public void RightButton() 
    {
        for (int i = 0; i < airplanes.Length; i++)
        {
            if (airplanes[i].activeInHierarchy == true)
            {
                if (i == airplanes.Length-1)
                {
                    airplanes[i].SetActive(false);
                    i = 0;
                    airplanes[i].SetActive(true);
                    break;
                }
                airplanes[i].SetActive(false);
                airplanes[i+1].SetActive(true);
                break;
            }
        }
    }
    public void LeftButton()
    {
        for (int i = 0; i < airplanes.Length; i++)
        {
            if (airplanes[i].activeInHierarchy == true)
            {
                if (i == 0)
                {
                    airplanes[i].SetActive(false);
                    i = airplanes.Length - 1; ;
                    airplanes[i].SetActive(true);
                    break;
                }
                airplanes[i].SetActive(false);                
                airplanes[i - 1].SetActive(true);
                break;
            }
        }
    }
    public void GreenButton()
    {
        for (int i = 0; i < airplanes.Length; i++)
        {
            if (airplanes[i].activeInHierarchy == true)
            {
                airplanes[i].GetComponent<MeshRenderer>().material.color = Color.green;
            }
        }
    }    
    public void BlueButton()
    {
        for (int i = 0; i < airplanes.Length; i++)
        {
            if (airplanes[i].activeInHierarchy == true)
            {
                airplanes[i].GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        }
    }
    public void YellowButton()
    {
        for (int i = 0; i < airplanes.Length; i++)
        {
            if (airplanes[i].activeInHierarchy == true)
            {
                airplanes[i].GetComponent<MeshRenderer>().material.color = Color.yellow;
            }
        }
    }
    public void RedButton()
    {
        for (int i = 0; i < airplanes.Length; i++)
        {
            if (airplanes[i].activeInHierarchy == true)
            {
                airplanes[i].GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }
    }   
}