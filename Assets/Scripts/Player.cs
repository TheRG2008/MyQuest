using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;
    [SerializeField] private AudioClip _step1;
    [SerializeField] private AudioClip _step2;
    [SerializeField] private AudioClip[] _step;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    public void PlayerIsDead()
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

    public void GetSoundSteps ()
    {
        _audioSource.PlayOneShot(_step[Random.Range(0, _step.Length)]);
    }


}
