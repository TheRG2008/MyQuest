using UnityEngine;

public class Scull : MonoBehaviour
{
    [SerializeField] private GameObject _particalSystem;
    public bool IsActive = false;    
    // Объекты для квеста активации портала. При активации IsActive == true, включаем ParticalSystem и звук
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F))
            {
                _particalSystem.SetActive(true);
                gameObject.GetComponentInParent<AudioSource>().enabled = true;
                IsActive = true;
            }            
        }
    }
}
