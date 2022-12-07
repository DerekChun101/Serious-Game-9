using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] public int MaxHealth;
    [SerializeField] public int armor;
    [SerializeField] public int strength;
    [SerializeField] AudioSource audios;
    public int currentHealth;

    public HealthBar healthBar; 
    

    // Start is called before the first frame update
    private void Start()
    {
        MaxHealth = PlayerData.Instance.getHealth();
        armor = PlayerData.Instance.getArmor();
        strength = PlayerData.Instance.getStrength();
        currentHealth = PlayerData.Instance.getCurrentHealth(); //MaxHealth; ;
        healthBar.SetMaxHealth(MaxHealth);
        healthBar.SetHealth(currentHealth);
        
        
    }

    public int returnstrength(){
        return strength;
    }

    public void damage(int x)
    {
        AudioSource.PlayClipAtPoint(audios.clip, transform.position);
        x -= armor;
        if(x <= 1)
        {
            currentHealth -= 1;
        } else
        {
            currentHealth -= x;
        }
        if (currentHealth <= 0)
        {
            Debug.Log("You Lose");
            SceneManager.LoadScene("DeathScreen");

        }
        PlayerData.Instance.setCurrentHealth(currentHealth);
        healthBar.SetHealth(currentHealth);
    }
}
