using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{

    public Rigidbody2D projectile;
    public float cadencia = 1;
    public Transform target;
    public bool disparaaljugador = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        target = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {

        //activará las balas que siguen al jugador

        if (disparaaljugador)
        {
            Vector2 direction = target.position - transform.position;
            transform.rotation = Quaternion.FromToRotation(Vector3.up, -direction);
        }
    }

    IEnumerator ExampleCoroutine()
    {
       

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(cadencia);
        FireEnemyBullet();
        StartCoroutine(ExampleCoroutine());

    }

    void FireEnemyBullet() 
    {
        Debug.Log("disparando");
            Rigidbody2D clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);

        
    }

    
}
