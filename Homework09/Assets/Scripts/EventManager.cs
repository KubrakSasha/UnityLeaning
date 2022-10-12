using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action PlayerDied;
    public static event Action Restart;
    
    public static void OnPlayerDied() 
    {
        PlayerDied?.Invoke();    
    }

    public static void OnRestart()
    {
        Restart?.Invoke();
    }
}
