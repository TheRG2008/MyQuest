
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject _door;    
    public bool IsOpen;    
    
    
// Проверяет взял ли Player ключ от этой двери (IsOpen) если да то дверь открывается.
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
