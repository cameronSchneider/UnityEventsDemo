using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulateObjectUnityEvents : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    public void ChangeColor(Color c)
    {
        Color current = GetComponent<Renderer>().material.color;
        
        if(current == c)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<Renderer>().material.color = c;
        }
    }

    public void Move()
    {
        Vector3 translation = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f));
        transform.position += translation;
    }
}
