using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject _door;    
    public bool IsOpen;    
    
    

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
      
            if (IsOpen == true)
            {               
                if (Input.GetKey(KeyCode.F))
                {
                    _door.GetComponent<Animator>().enabled = true;
                    _door.GetComponent<AudioSource>().enabled = true;

                }

            }
        }
       

    }
}
