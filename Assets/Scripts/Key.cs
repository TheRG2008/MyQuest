using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private GameObject _button;
    [SerializeField] private GameObject _keySound;
    [SerializeField] private GameObject _door;
   

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            _door.GetComponent<Door>().IsOpen = true;
            EnterAnimation();
        }

    }

    void StopKeySound ()
    {
        _keySound.GetComponent<AudioSource>().enabled = false;
        CancelInvoke();

    }

    void EnterAnimation ()
    {
        _keySound.GetComponent<AudioSource>().enabled = true;
        _button.SetActive(true);
        gameObject.SetActive(false);
        Invoke("StopKeySound", 3);
    }

}
