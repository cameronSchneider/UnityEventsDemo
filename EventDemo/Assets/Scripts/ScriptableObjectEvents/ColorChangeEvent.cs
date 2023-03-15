using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Event/ColorChangeEvent")]
public class ColorChangeEvent : ScriptableObject
{
    private List<ColorChangeEventListener> listeners = new List<ColorChangeEventListener>();

    public virtual void TriggerEvent(Color color)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventTriggered(color);
        }
    }
    public void AddListener(ColorChangeEventListener listener)
    {
        listeners.Add(listener);
    }
    public void RemoveListener(ColorChangeEventListener listener)
    {
        listeners.Remove(listener);
    }
}