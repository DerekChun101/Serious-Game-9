using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
                  
    Vector2[] vectors = { new Vector2(3, 1.8f), new Vector2(5, 1.8f), new Vector2(7, 1.8f) };
    Vector2[] vectors2 = { new Vector2(3, 4.33f), new Vector2(5, 4.33f), new Vector2(7, 4.33f) };
    public int Num_Enemy;

    // Start is called before the first frame update
    void Start()
    {
        Num_Enemy = Random.Range(1, 4);
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void Spawn()
    {
        for (int i = 1; i <= Num_Enemy; i++)
        {
            GameObject new_Enemy = Instantiate(enemy, vectors[i - 1], Quaternion.identity);
            

        }
    }
}

