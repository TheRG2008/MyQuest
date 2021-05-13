
using UnityEngine;

public class Scull : MonoBehaviour
{
    [SerializeField] private GameObject _particalSystem;
    public bool IsActive = false;
    

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
