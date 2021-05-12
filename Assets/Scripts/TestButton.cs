using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestButton : MonoBehaviour
{
    
    public UnityEvent PushEvent;
    


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            PushEvent.Invoke();
           
        }
    }

   
}

