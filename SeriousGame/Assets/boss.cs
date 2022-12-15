using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] public int armor;
    [SerializeField] public int strength;
    [SerializeField] AudioSource audio1;
    public HealthBar healthBar; 
    void Start()
    {
        health = 15;
        armor = 2;
        strength = 2;
        healthBar.SetMaxHealth(health);
        healthBar.SetHealth(health);
    }

    // Update is called once per frame
    
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
            StartCoroutine(Death());
        }
    }
    IEnumerator Death() {
         AudioSource.PlayClipAtPoint(audio1.clip, transform.position);
        yield return new WaitForSeconds(1);
         Destroy(gameObject);
    }
}

