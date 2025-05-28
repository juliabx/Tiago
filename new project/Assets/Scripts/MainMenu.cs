using UnityEngine;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public Button quitButton;

    private void Start()
    {
        startButton.onClick.AddListener(StartGame);
        quitButton.onClick.AddListener(QuitGame);
    }

    void StartGame()
    {
        GameManager.Instance.LoadGameAndGUI();
    }

    void QuitGame()
    {
        Application.Quit();
        Debug.Log("Application.Quit() chamado.");
    }
}
