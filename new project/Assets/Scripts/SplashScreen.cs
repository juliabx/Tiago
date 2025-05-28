using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    private void Start()
    {
        Invoke("GoToMainMenu", 2f);
    }

    void GoToMainMenu()
    {
        GameManager.Instance.LoadScene("MainMenu");
    }
}
