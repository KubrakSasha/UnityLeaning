using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{ 
    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject buttons;
    [SerializeField]
    private GameObject toggles;
    [SerializeField]
    private GameObject drops;
    [SerializeField]
    private GameObject input;    
    [SerializeField]
    private GameObject scrollView;
    [SerializeField]
    private GameObject menuBack;
    public ButtonsMenu buttonsmenu;
    public TogglesMenu togglesmenu;
    public DropsMenu dropsMenu;

    public void Start()
    {
        menuBack.SetActive(false);
        BackToMainMenu();
    }
    public void ButtonsButton()
    {
        buttons.SetActive(true);
        mainMenu.SetActive(false);
        menuBack.SetActive(true);
        buttonsmenu.buttonOne.GetComponent<Button>().enabled = true;
        buttonsmenu.buttonTwo.GetComponent<Button>().enabled = true;
        buttonsmenu.buttonDisable.GetComponent<Button>().enabled = true;
        buttonsmenu.oneText.SetActive(false);
        buttonsmenu.twoText.SetActive(false);
    }
    public void TogglesButton()
    {
        toggles.SetActive(true);
        mainMenu.SetActive(false);
        menuBack.SetActive(true);
        togglesmenu.oneText.SetActive(false);
        togglesmenu.twoText.SetActive(false);
        togglesmenu.threeText.SetActive(false);
    }
    public void DropsButton()
    {
        drops.SetActive(true);
        mainMenu.SetActive(false);
        menuBack.SetActive(true);
        //GetComponent<Dropdown>().value = 0;
        dropsMenu.textA.SetActive(false);
        dropsMenu.textB.SetActive(false);
        dropsMenu.textC.SetActive(false);
        dropsMenu.textD.SetActive(false);      
    }
    public void InputButton()
    {
        input.SetActive(true);
        mainMenu.SetActive(false);
        menuBack.SetActive(true);
    }
    public void ScrollViewButton()
    {
        scrollView.SetActive(true);
        mainMenu.SetActive(false);
        menuBack.SetActive(true);
    }


    public void BackToMainMenu() 
    {
        buttons.SetActive(false);
        toggles.SetActive(false);
        drops.SetActive(false);
        input.SetActive(false);
        scrollView.SetActive(false);
        mainMenu.SetActive(true);
        menuBack.SetActive(false);
    }    
}
