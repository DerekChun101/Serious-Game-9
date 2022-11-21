using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{

    int playerHealth;
    int playerArmor;
    int playerStrength;
    int[] openNode = new int[2];
    int depth;

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
        depth = 0;
        openNode[0] = 0;
        openNode[1] = -1;
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

    public void setOpen1(int x)
    {
        openNode[0] = x;
    }

    public void setOpen2(int x)
    {
        openNode[1] = x;
    }

    public int getOpen1()
    {
        return openNode[0];
    }

    public int getOpen2()
    {
        return openNode[1];
    }

    public void setDepth()
    {
        depth++;
    } 

    public int getDepth()
    {
        return depth;
    }
}