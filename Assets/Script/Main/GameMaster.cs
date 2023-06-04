using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    [SerializeField] private GameObject WinMenu;
    [SerializeField] private GameObject HealthBar;
    [SerializeField] private PlayerHealth player;
    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (player != null && player.health == 20)
        {
            PlayerWin();
        } 
    }

    public void PlayerWin()
    {
        WinMenu.SetActive(true);
        HealthBar.SetActive(false);
        Time.timeScale = 0f;
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
