using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;    
    private Animator _anim;
    private AudioSource _sourse;


    private void Start()
    {
        _anim = GetComponent<Animator>();
        _sourse = GetComponent<AudioSource>();


    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F))
            {
                _anim.SetBool("enter", true);
                _sourse.Play();
                _enemy.SetActive(false);
            }
        }

       
    }
}



        
    