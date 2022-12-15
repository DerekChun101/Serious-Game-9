using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Started");
      
    }

    public void Settings()
    {
        if (PlayerData.Instance.getSettingsOpen())
        {
            foreach (GameObject g in PlayerData.Instance.getSettingsMenu())
            {
                g.SetActive(false);
            }
            PlayerData.Instance.setSettingsOpen();
        }
        else
        {
            foreach (GameObject g in PlayerData.Instance.getSettingsMenu())
            {
                g.SetActive(true);
            }
            PlayerData.Instance.setSettingsOpen();
        }
    }
}

