
using UnityEngine;
// А нужен ли этот скрипт?
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
