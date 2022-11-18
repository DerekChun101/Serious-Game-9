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
        health = 10;
        armor = 1;
        strength = 2;
    }

    // Update is called once per frame
    private void Update()
    {
        if(health <= 0)
        {
            Debug.Log("You Lose");
        }
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
    }
}
