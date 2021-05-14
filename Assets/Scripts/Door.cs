using UnityEngine.Events;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject _door;    
    public bool IsOpen;
    public UnityEvent ExitEvent;
    public UnityEvent EnterEvent;


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

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ExitEvent.Invoke();
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            EnterEvent.Invoke();
        }

    }
}
