using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Credits;
    public GameObject Options;



    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Confined;

    }

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
        Cursor.lockState = CursorLockMode.None;
    }

    public void StartGameButton() //Clicking the start game button
    {

        SceneManager.LoadScene("TestScene");
    }

    public void CreditsButton() //Clicking the credits Button
    {
        Menu.SetActive(false); //Disables the menu UI components
        Credits.SetActive(true); //Enables the Credits UI Components
        Options.SetActive(false); ////Disables the options UI components
    }

    public void MainMenuButton()
    {
        Menu.SetActive(true);
        Credits.SetActive(true);
        Options.SetActive(true);
    }

    public void SettingsButton()
    {
        Menu.SetActive(false);
        Credits.SetActive(false);
        Options.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
