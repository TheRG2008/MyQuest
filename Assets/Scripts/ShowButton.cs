using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButton : MonoBehaviour
{
    [SerializeField] private GameObject _button;
    private AudioSource _sourse;
    private Animator _anim;

    private void Awake()
    {
        _sourse = GetComponent<AudioSource>();
        _anim = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F))
            {
                _anim.SetBool("enter", true);
                _button.SetActive(true);
                _sourse.Play();

            }
            
        }
    }
}
