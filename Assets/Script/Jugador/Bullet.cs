using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    

    private void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        // traslade a la dirección que le ponga x, y, z (esta última es para juegos 3D, en este caso sería "x" e "y") con una velocidad que también establezca
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyController>() != null) 
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
            
        }
       
    }
}
