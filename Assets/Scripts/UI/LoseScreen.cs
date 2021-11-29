using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject _loseScreen;

    public static LoseScreen Instance { get; private set; }


    void Awake()
    {
        Instance = this;
    }


    private void Start()
    {
        _loseScreen.SetActive(false);
    }


    public void RestartGameOnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void GameLost()
    {
        _loseScreen.SetActive(true);

        Time.timeScale = 0;
    }
}
