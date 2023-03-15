using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Event/MoveEvent")]
public class MoveEvent : ScriptableObject
{
    private List<MoveEventListener> listeners = new List<MoveEventListener>();

    public virtual void TriggerEvent()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventTriggered();
        }
    }
    public void AddListener(MoveEventListener listener)
    {
        listeners.Add(listener);
    }
    public void RemoveListener(MoveEventListener listener)
    {
        listeners.Remove(listener);
    }
}