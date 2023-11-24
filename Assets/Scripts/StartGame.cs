using UnityEngine;


public class StartGame : MonoBehaviour
{
    public Canvas MainMenu;
    public Canvas LoadingScreen;

    public void StartGameButton()
    {
        MainMenu.enabled = false;
        LoadingScreen.enabled = true;
        Invoke(nameof(LoadedLevel), 1.0f);
    }

    private void LoadedLevel()
    {
        LoadingScreen.enabled = false;
    }
}
