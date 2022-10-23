using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class bookScript : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public GameObject button;

    void OnTriggerEnter(Collider collider)
    {
         Debug.Log("a");
         unityEvent.Invoke();
        
    }
}
