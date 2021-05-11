using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastEnemyActive : MonoBehaviour
{
    [SerializeField] private GameObject _fastEnemy; 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _fastEnemy.GetComponent<Enemy>().enabled = true;
        }
    }
}
