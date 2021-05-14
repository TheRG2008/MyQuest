using UnityEngine;
using UnityEngine.Events;

public class TestButton : MonoBehaviour
{

    public UnityEvent AtackEvent;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AtackEvent.Invoke();

        }
    }


}
