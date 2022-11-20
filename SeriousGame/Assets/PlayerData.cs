using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{

    int playerHealth;
    int playerArmor;
    int playerStrength;

    public static PlayerData Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        playerHealth = 10;
        playerArmor = 1;
        playerStrength = 2;
    }

    public void setHealth(int x)
    {
        playerHealth = x;
    }

    public void setArmor(int x)
    {
        playerArmor = x;
    }

    public void setStrength(int x)
    {
        playerStrength = x;
    }

    public int getHealth()
    {
        return playerHealth;
    }

    public int getArmor()
    {
        return playerArmor;
    }

    public int getStrength()
    {
        return playerStrength;
    }
}