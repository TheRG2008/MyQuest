
using UnityEngine;

public class Spider : MonoBehaviour
{
    [SerializeField] private GameObject _spider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _spider.SetActive(true);
        }
    }
}
