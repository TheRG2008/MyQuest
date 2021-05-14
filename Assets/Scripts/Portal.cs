using UnityEngine;
using UnityEngine.Events;

public class Portal : MonoBehaviour
{
    //Создаем массив объектов которые будут учавствовать в активации портала
    [SerializeField] private GameObject[] _sculs;
    private int _count = 0;
    public UnityEvent ExitEvent;
    public UnityEvent EnterEvent;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            //Циклом проверяем активирована ли все объекты массива, через счетчик _count;
            //Если нет => обнуляем счетчик _count;
            //Если да => активируем анимацию появления портала
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
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ExitEvent.Invoke();
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            EnterEvent.Invoke();
        }

    }

}
