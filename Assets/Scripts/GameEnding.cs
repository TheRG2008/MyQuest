
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameEnding : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;
    [SerializeField] private GameObject _player;
    private Animator _anim;    
    public UnityEvent PushEvent;
    
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    
    //Проверяем попал ли в коллайдер Player, если да то => анимация => события => логика смерти 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _anim.SetBool("walk", false);
            _anim.SetBool("atack", true);
            PushEvent.Invoke();
            Invoke ("PlayerIsDead",1f);
        }        
    }
    
    private void PlayerIsDead ()
    {
        _canvas.SetActive(true);
        _player.GetComponent<PlayerMove>().enabled = false;
        _player.GetComponent<Animator>().SetBool("walk", false);
        Invoke("ReloadScene", 2);
        
    }

    private void ReloadScene ()
    {
        //Метод для перезагрузки текущей сцены
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        CancelInvoke();
    }
}
