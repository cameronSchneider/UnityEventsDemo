using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulateObjectActions : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        MainControllerActions.ColorChangeEventAction += ChangeColor;
        MainControllerActions.ColorChangedEventFunc += ChangeColorFunc;
        MainControllerActions.MoveEvent += Move;
    }

    private void OnDisable()
    {
        MainControllerActions.ColorChangeEventAction -= ChangeColor;
        MainControllerActions.ColorChangedEventFunc -= ChangeColorFunc;
        MainControllerActions.MoveEvent -= Move;
    }

    void ChangeColor(Color c)
    {
        GetComponent<Renderer>().material.color = c;
    }

    bool ChangeColorFunc(Color c)
    {
        GetComponent<Renderer>().material.color = c;
        return true;
    }

    void Move()
    {
        Vector3 translation = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f));
        transform.position += translation;
    }
}
