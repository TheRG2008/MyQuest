using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{    
    public UnityEvent PushEvent;
    public UnityEvent ExitEvent;
    public UnityEvent EnterEvent;
    
    //Скрипт запуска событий на кнопки в сцене
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            PushEvent.Invoke();
            Destroy(gameObject);
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
        if(other.tag == "Player")
        {
            EnterEvent.Invoke();
        }
        
    }
}

