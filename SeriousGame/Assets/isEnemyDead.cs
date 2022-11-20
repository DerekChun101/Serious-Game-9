using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isEnemyDead : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindWithTag("Enemy");
        if(enemy == null)
        {
            Win();
        }
        
    }
    void Win()
    {
        if (enemy == null)
        {
            enabled = false;
            Debug.Log("You Win");
            SceneManager.LoadScene("Map");
        }
    }
}