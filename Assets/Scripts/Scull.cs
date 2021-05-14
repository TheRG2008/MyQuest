using UnityEngine;
using UnityEngine.Events;

public class Scull : MonoBehaviour
{
    [SerializeField] private GameObject _particalSystem;
    [SerializeField] private GameObject _scullCanvas;
    public bool IsActive = false;
    public UnityEvent ExitEvent;
    public UnityEvent EnterEvent;
    // Объекты для квеста активации портала. При активации IsActive == true, включаем ParticalSystem и звук
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F))
            {
                _particalSystem.SetActive(true);
                gameObject.GetComponentInParent<AudioSource>().enabled = true;
                _scullCanvas.SetActive(true);
                IsActive = true;
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
