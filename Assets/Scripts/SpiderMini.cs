using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMini : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
        
    }

}
