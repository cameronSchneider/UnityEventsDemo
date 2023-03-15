using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControllerDelegates : MonoBehaviour
{
    public delegate bool ColorChanged();
    public static ColorChanged colorChanged;

    public delegate void TriggerMove(Vector3 translation);
    public static TriggerMove triggerMove;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            bool colorChangeSuccess = (bool)colorChanged?.Invoke();
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Vector3 translation = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f));

            triggerMove?.Invoke(translation);
        }
    }
}
