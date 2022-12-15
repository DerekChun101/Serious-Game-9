using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] public int armor;
    [SerializeField] public int strength;
    [SerializeField] AudioSource audio1;
    public HealthBar healthBar; 
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "Enemy")
        {
            health = 4;
            armor = 0;
            strength = 2;
        }
        else if(gameObject.tag == "boss")
        {
            health = 15;
            armor = 2;
            strength = 4;
            healthBar.SetMaxHealth(health);
            healthBar.SetHealth(health);
        }
    }
    public int returnstrength(){
        return strength;
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
            StartCoroutine(Death());
        }
        healthBar.SetHealth(health);
    }
    IEnumerator Death() {
         AudioSource.PlayClipAtPoint(audio1.clip, transform.position);
        yield return new WaitForSeconds(1);
         Destroy(gameObject);
    }
}
