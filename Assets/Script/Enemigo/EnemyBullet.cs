using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

   // public  float speed;//velocidad de la bala
    Rigidbody2D mirb2d;
    public float speed = 3;
    //set default values in Awake function
    //public Vector2 direccion ;

  
    // Start is called before the first frame update
    void Start()
    {
        mirb2d = GetComponent<Rigidbody2D>();

    }

   

    // Update is called once per frame
    void Update()
    {

        //mirb2d.AddForce(transform.forward * speed);

        mirb2d.velocity = transform.up * -speed;

         //  Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

         //   Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));


         // if ((transform.position.x < min.x) || (transform.position.x > max.x) || (transform.position.y < min.y) || (transform.position.y < max.y)) 
        //  {
         //    Destroy(gameObject);
       // }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Escudo"))
        {
            Destroy(gameObject);
        }

    }
}
