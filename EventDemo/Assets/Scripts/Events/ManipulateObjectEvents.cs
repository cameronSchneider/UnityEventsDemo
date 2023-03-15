using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulateObjectEvents : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        MainControllerEvents.colorEvent += ChangeColor;
        MainControllerEvents.moveEvent += Move;
    }

    private void OnDisable()
    {
        MainControllerEvents.colorEvent -= ChangeColor;
        MainControllerEvents.moveEvent -= Move;
    }

    void ChangeColor()
    {
        GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    void Move()
    {
        Vector3 translation = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f));
        transform.position += translation;
    }
}
