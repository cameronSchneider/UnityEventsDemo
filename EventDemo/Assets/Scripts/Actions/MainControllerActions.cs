using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using static MainControllerDelegates;

public class MainControllerActions : MonoBehaviour
{
    public static event Action<Color> ColorChangeEventAction;
    public static event Func<Color, bool> ColorChangedEventFunc;
    public static event Action MoveEvent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Color random = new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));
            ColorChangeEventAction?.Invoke(random);
        }

        if(Input.GetKeyUp(KeyCode.RightShift)) 
        {
            Color random = new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));
            bool result = (bool)ColorChangedEventFunc?.Invoke(random);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            MoveEvent?.Invoke();
        }
    }
}
