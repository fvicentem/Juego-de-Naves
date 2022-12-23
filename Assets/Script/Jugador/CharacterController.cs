using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CharacterController : MonoBehaviour
{

    public float speed = 0f;
    public Transform shootOrigin; //posición origen de la bala
    public GameObject shootPrefab; //el prefab que se mostrará, en este caso la bala
    public Transform shieldOrigin; //posición origen del escudo
    public GameObject shield; //el prefab que se mostrará, en este caso del escudo

    //Variable para acceder al controlador de animaciones
    private Animator anim;
    //Variable que nos permite acceder al SpriteRenderer de nuestro jugador
    private SpriteRenderer theSR;



    // Start is called before the first frame update
    void Start()
    {
        //Inicialización del animator de nuestro Player
        anim = GetComponent<Animator>(); //vete al GO donde está este Script metido, y coge el componente de Animator Controller
        //Inicialización del SpriteRenderer de nuestro Player
        theSR = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(SimpleInput.GetAxis("Horizontal")* speed * Time.deltaTime, SimpleInput.GetAxis("Vertical") * speed * Time.deltaTime, transform.position.z);


        
     


        //Poner un boton para disparar en PC, android, etc
        if (SimpleInput.GetButtonDown("Shoot"))
           {
            //se crea la bala cada vez que presiono el boton con todo y script Bullet
            Instantiate (shootPrefab, shootOrigin, false);
            AudioManager.instance.PlaySound(0);
           }

        if (SimpleInput.GetButtonDown("Shield"))
        {
            //se crea la bala cada vez que presiono el boton con todo y script Bullet
            //(shieldPrefab, shieldOrigin, true);
            shield.SetActive(true);
            AudioManager.instance.PlaySound(1);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemigo")
        {
            HealthPlayer.instance.currentHealth--;
            Debug.Log("test");
        }
    }
}
