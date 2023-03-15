using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static MainControllerDelegates;

public class MainControllerUnityScriptable : MonoBehaviour
{
    public ColorChangeEvent colorEvent;
    public MoveEvent moveEvent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Color random = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            colorEvent.TriggerEvent(random);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveEvent.TriggerEvent();
        }
    }
}
