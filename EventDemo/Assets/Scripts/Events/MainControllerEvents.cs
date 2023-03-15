using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MainControllerDelegates;

public class MainControllerEvents : MonoBehaviour
{
    public delegate void ColorEvent();
    public static event ColorEvent colorEvent;

    public delegate void MoveEvent();
    public static event MoveEvent moveEvent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            colorEvent?.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveEvent?.Invoke();
        }
    }
}
