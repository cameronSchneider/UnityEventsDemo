using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class MoveEventListener : MonoBehaviour
{
    public MoveEvent gameEvent;
    public UnityEvent onEventTriggered;
    void OnEnable()
    {
        gameEvent.AddListener(this);
    }
    void OnDisable()
    {
        gameEvent.RemoveListener(this);
    }
    public void OnEventTriggered()
    {
        onEventTriggered.Invoke();
    }

    public void Move()
    {
        Vector3 translation = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f));
        transform.position += translation;
    }
}