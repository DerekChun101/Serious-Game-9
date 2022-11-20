using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] public int armor;
    [SerializeField] public int strength;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "Enemy")
        {
            health = 5;
            armor = 0;
            strength = 1;
        }
        else if(gameObject.tag == "Enemy2")
        {
            health = 5;
            armor = 1;
            strength = 1;
        }
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
