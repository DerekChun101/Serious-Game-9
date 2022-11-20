using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] public int armor;
    [SerializeField] public int strength;

    // Start is called before the first frame update
    private void Start()
    {
        health = PlayerData.Instance.getHealth();
        armor = PlayerData.Instance.getArmor();
        strength = PlayerData.Instance.getStrength();
    }

    public void damage(int x)
    {
        x -= armor;
        if(x <= 1)
        {
            health -= 1;
        } else
        {
            health -= x;
        }
        if (health <= 0)
        {
            Debug.Log("You Lose");
        }
        PlayerData.Instance.setHealth(health);
    }
}
