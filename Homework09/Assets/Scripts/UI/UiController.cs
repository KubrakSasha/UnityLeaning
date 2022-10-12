using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    Canvas canvas;
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.gameObject.SetActive(false);
        
        button = GetComponentInChildren<Button>();
        button.onClick.AddListener(EventManager.OnRestart);
        EventManager.PlayerDied += ShowGameOver;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowGameOver() 
    {
        canvas.gameObject.SetActive(true);
    }
    

}
