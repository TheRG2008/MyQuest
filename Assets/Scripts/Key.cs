
using UnityEngine;

public class Key : MonoBehaviour
{    
    [SerializeField] private GameObject _keySound;
    [SerializeField] private GameObject _door;   

    //Проверяем находиться ли Player в Коллайдере => возвращаем true связанной с этим ключем двери
    private void OnTriggerEnter(Collider other)
    {        
        if (other.tag == "Player")
        {
            _door.GetComponent<Door>().IsOpen = true;
            EnterAnimation();
        }
    }  
    //Активируем звук подбора ключа, уничтожаем GameObject
    void EnterAnimation ()
    {
        _keySound.GetComponent<AudioSource>().enabled = true;        
        gameObject.SetActive(false);
        Invoke("StopKeySound", 3);
    }
    
    //Декактивируем звук подбора ключа, что бы сработал звук при подборе следующего ключа
      void StopKeySound ()
    {
        _keySound.GetComponent<AudioSource>().enabled = false;
        CancelInvoke();
    }

}
