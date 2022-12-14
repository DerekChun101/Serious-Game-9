using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isBossDead : MonoBehaviour
{
    [SerializeField] AudioSource audio1;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindWithTag("boss");
        if(enemy == null)
        {
            StartCoroutine(Win());
        }
        
    }
    IEnumerator Win()
    {
        if (enemy == null)
        {
            enabled = false;
            Debug.Log("You Win");
            AudioSource.PlayClipAtPoint(audio1.clip, transform.position);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("Map");
        }
    }
}
