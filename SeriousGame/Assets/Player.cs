using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] public int MaxHealth;
    [SerializeField] public int armor;
    [SerializeField] public int strength;
    [SerializeField] AudioSource audio1;
    [SerializeField] AudioSource audio2;
    public int currentHealth;
    public HealthBar healthBar; 
    public Animator animator;

    // Start is called before the first frame update
    private void Start()
    {
        MaxHealth = PlayerData.Instance.getHealth();
        armor = PlayerData.Instance.getArmor();
        strength = PlayerData.Instance.getStrength();
        currentHealth = PlayerData.Instance.getCurrentHealth(); //MaxHealth; ;
        healthBar.SetMaxHealth(MaxHealth);
        healthBar.SetHealth(currentHealth);
        animator.SetBool("Attack", false);
        
    }

    public int returnstrength(){
        return strength;
    }

    public void damage(int x)
    {
        AudioSource.PlayClipAtPoint(audio1.clip, transform.position);
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
            StartCoroutine(Death());
            Debug.Log("You Lose");
            

        }
        PlayerData.Instance.setCurrentHealth(currentHealth);
        healthBar.SetHealth(currentHealth);
    }
    IEnumerator Death() {
            AudioSource.PlayClipAtPoint(audio2.clip, transform.position);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("DeathScreen");
    }
}
