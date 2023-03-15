using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static MainControllerDelegates;

public class MainControllerUnityEvents : MonoBehaviour
{
    public UnityEvent<Color> ColorChangeEvent;
    public UnityEvent MoveEvent;

    public Color currentColor;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ColorChangeEvent.Invoke(currentColor);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            MoveEvent.Invoke();
        }
    }
}
