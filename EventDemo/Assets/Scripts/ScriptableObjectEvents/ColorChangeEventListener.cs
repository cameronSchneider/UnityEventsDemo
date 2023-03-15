using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ColorChangeEventListener : MonoBehaviour
{
    public ColorChangeEvent gameEvent;
    public UnityEvent<Color> onEventTriggered;
    void OnEnable()
    {
        gameEvent.AddListener(this);
    }
    void OnDisable()
    {
        gameEvent.RemoveListener(this);
    }
    public void OnEventTriggered(Color color)
    {
        onEventTriggered.Invoke(color);
    }

    public void SetColor(Color c)
    {
        GetComponent<Renderer>().material.color = c;
    }
}