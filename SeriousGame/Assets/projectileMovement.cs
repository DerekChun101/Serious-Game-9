using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    Rigidbody2D rigid;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
        {
            rigid = GetComponent<Rigidbody2D>(); 
        }
        gameObject.tag = "projectile";
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(3, 0);
    }
    void FixedUpdate()
    {
        rigid.AddForce(movement * speed);
        Destroy(gameObject,3);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if ((other.gameObject.CompareTag("Enemy")))
        {
            Destroy(gameObject);
        }
    }
}
