using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActiveButton : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    private Animator _anim;
    

    private void Start()
    {
        _anim = GetComponent<Animator>();
        
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F))
            {
                _anim.SetBool("enter", true);
                _enemy.GetComponent<AudioSource>().enabled = true;
                _enemy.GetComponent<Enemy>().enabled = true;
            }
        }

       
    }
}
