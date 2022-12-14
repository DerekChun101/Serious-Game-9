using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{

    int playerHealth;
    int playerArmor;
    int playerStrength;
    int[] openNode = new int[2];
    [SerializeField] int depth;
    int[] nodes = new int[13];
    bool set;
    bool settingsOpen;
<<<<<<< Updated upstream
=======
    public GameObject[] settingsMenu;
    bool[] visited = new bool[15];
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
=======

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
>>>>>>> Stashed changes
        playerHealth = 10;
        playerArmor = 1;
        playerStrength = 2;
        depth = 0;
        openNode[0] = 0;
        openNode[1] = -1;
        set = false;
<<<<<<< Updated upstream
        settingsOpen = false;
=======
        for(int i = 0; i < visited.Length; i++)
        {
            visited[i] = false;
        }
    }
    public void setCurrentHealth(int x)
    {
        playerCurrentHealth = x;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream

=======
    public int getCurrentHealth()
    {
        return playerCurrentHealth;
    }
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======

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
>>>>>>> Stashed changes
}