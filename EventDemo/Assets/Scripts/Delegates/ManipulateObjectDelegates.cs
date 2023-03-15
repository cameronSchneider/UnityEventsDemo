using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulateObjectDelegates : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        MainControllerDelegates.triggerMove += Move;
        MainControllerDelegates.colorChanged += ChangeColor;
    }

    private void OnDisable()
    {
        MainControllerDelegates.triggerMove -= Move;
        MainControllerDelegates.colorChanged -= ChangeColor;
    }

    bool ChangeColor()
    {
        GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        return true;
    }

    void Move(Vector3 difference)
    {
        transform.position += difference;
    }
}
