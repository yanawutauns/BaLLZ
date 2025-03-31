using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MapScene");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");

    }
    public void GameScene2()
    {
        SceneManager.LoadScene("GameScene2");

    }
}
