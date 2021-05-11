using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonForFastEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _falseFloor;
    [SerializeField] private GameObject _trapSound;
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
                _falseFloor.SetActive(false);
                _trapSound.GetComponent<AudioSource>().enabled = true;

                Invoke("EnemyDawn", 1);
            }
        }


    }
    void EnemyDawn ()
    {
        _anim.SetBool("enter", true);
        _enemy.GetComponent<AudioSource>().enabled = true;
        _enemy.GetComponent<Animator>().SetBool("down", true);
        Destroy(_enemy, 1.4f);
        Invoke("TrapON", 1);
    
    }

    void TrapON ()
    {
        _falseFloor.SetActive(true);
    }


}
