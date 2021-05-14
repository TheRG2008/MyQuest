using UnityEngine;
using UnityEngine.Events;

public class EnemyAtack : MonoBehaviour
{    
    public UnityEvent AtackEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AtackEvent.Invoke();
            other.GetComponent<Player>().PlayerIsDead();

        }
    }

}
