using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;
    [SerializeField] private GameObject _player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Invoke ("PlayerIsDead",0.2f);
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        CancelInvoke();
    }


}
