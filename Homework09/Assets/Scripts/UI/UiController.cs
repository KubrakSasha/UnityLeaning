using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    Canvas canvas;
    Button button;
   
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.gameObject.SetActive(false);
        
        button = GetComponentInChildren<Button>();
        button.onClick.AddListener(EventManager.OnRestart);
        EventManager.PlayerDied += ShowGameOver;        
    }
    public void ShowGameOver() 
    {
        canvas.gameObject.SetActive(true);
    }
}