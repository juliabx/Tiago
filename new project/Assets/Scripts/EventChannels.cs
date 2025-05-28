using UnityEngine;
using System;

public static class EventChannels
{
    public static Action<string> OnButtonPressed;

    public static void ButtonPressed(string buttonID)
    {
        OnButtonPressed?.Invoke(buttonID);
    }
    
        
    
}
