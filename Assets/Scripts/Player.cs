using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;


    private void PlayerIsDead()
    {
        _canvas.SetActive(true);
        GetComponent<PlayerMove>().enabled = false;
        GetComponent<Animator>().SetBool("walk", false);
        Invoke("ReloadScene", 2);

    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        CancelInvoke();
    }

}
