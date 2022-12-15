using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{

    int playerHealth;
    int playerCurrentHealth;
    int playerArmor;
    int playerStrength;
    int[] openNode = new int[2];
    int depth;
    int[] nodes = new int[13];
    bool set;
    bool settingsOpen;
    public GameObject[] settingsMenu;
    bool[] visited = new bool[15];
    bool difficultFight = false;

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
        settingsOpen = false;
        settingsMenu = GameObject.FindGameObjectsWithTag("Settings");
        foreach (GameObject g in settingsMenu)
        {
            g.SetActive(false);
        }
        defaultSettings();
    }

    public void defaultSettings()
    {
        playerHealth = 10;
        playerCurrentHealth = playerHealth;
        playerArmor = 1;
        playerStrength = 2;
        depth = 0;
        openNode[0] = 0;
        openNode[1] = -1;
        set = false;
        for (int i = 0; i < visited.Length; i++)
        {
            visited[i] = false;
        }
    }
    public void setCurrentHealth(int x) 
    {
        playerCurrentHealth = x;
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
    public int getCurrentHealth() 
    {
        return playerCurrentHealth;
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

    public void setNodeTrue()
    {
        set = true;
    }

    public bool getSet()
    {
        return set;
    }

    public void setNode(int x, int i)
    {
        nodes[i] = x;
    }

    public int[] getNode()
    {
        return nodes;
    }

    public void setSettingsOpen()
    {
        settingsOpen = !settingsOpen;
    }

    public bool getSettingsOpen()
    {
        return settingsOpen;
    }

    public GameObject[] getSettingsMenu()
    {
        return settingsMenu;
    }

    public void setVisited(int i)
    {
        visited[i] = true;
    }

    public bool[] getVisited()
    {
        return visited;
    }

    public void setDifficultFight(bool x)
    {
        difficultFight = x;
    }

    public bool getDifficultFight()
    {
        return difficultFight;
    }
}