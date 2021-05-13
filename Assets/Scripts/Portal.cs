
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private GameObject[] _sculs;
    private int _count = 0;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            for (int i = 0; i < _sculs.Length; i++)
            {
                if (_sculs[i].GetComponent<Scull>().IsActive)
                {
                    _count += 1;
                }
            }

            if (_count == _sculs.Length)
            {
                gameObject.GetComponent<Animator>().enabled = true;
                gameObject.GetComponent<AudioSource>().enabled = true;
            }
            else
            {
                _count = 0;
            }
        }
    }

}
