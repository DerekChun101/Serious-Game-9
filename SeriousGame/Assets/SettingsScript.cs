using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] public GameObject[] settingsMenu;

    void Start()
    {
        Debug.Log("Started");
        settingsMenu = GameObject.FindGameObjectsWithTag("Settings");
        foreach (GameObject g in settingsMenu)
        {
            g.SetActive(false);
        }
    }

    public void Settings()
    {
        if (PlayerData.Instance.getSettingsOpen())
        {
            foreach (GameObject g in settingsMenu)
            {
                g.SetActive(false);
            }
            PlayerData.Instance.setSettingsOpen();
        }
        else
        {
            foreach (GameObject g in settingsMenu)
            {
                g.SetActive(true);
            }
            PlayerData.Instance.setSettingsOpen();
        }
    }
}

