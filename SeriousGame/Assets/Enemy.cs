using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] public int armor;
    [SerializeField] public int strength;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        armor = 0;
        strength = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damage(int x)
    {
        x -= armor;
        if (x <= 1)
        {
            health -= 1;
        }
        else
        {
            health -= x;
        }
        if (health <= 0)
        {
            death();
        }
    }

    public void death()
    {
        Destroy(gameObject);
    }
}
