using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Map");
        Debug.Log("Start");
    }

    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        PlayerData.Instance.defaultSettings();
        SceneManager.LoadScene("Main Menu");
    }
    public void goToInstructions()
    {
        SceneManager.LoadScene("InstructionsMenu");
    }
}
