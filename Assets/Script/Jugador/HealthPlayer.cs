using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{

    //Hacemos un Singleton del script. Es decir, hacemos que solamente pueda haber un script de este tipo. Podremos acceder con esta instance a este script desde cualquier lugar
    public static HealthPlayer instance;

    //Variables para controlar la vida actual y también el máximo de vida que podemos tener (esto es debido a que en un momento dado querremos recuperar vida, y no podremos recuperar más del máximo de vida permitido)
    public int currentHealth, maxHealth;

    //Variable control tiempo que el jugador es invencible al sufrir daño
    public float invincibleLength;

    //Contador del tiempo en activo de la invencibilidad
    private float invincibleCounter;

    //Variable para acceder al sprite renderer del jugador
    private SpriteRenderer theSR;

    private void Awake()
    {
        //Significa que la instance del PlayerHealthController va a ser este propio script
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Cuando empieza el juego
        currentHealth = maxHealth;
        //Inicializamos el sprite renderer del jugador
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }

        //Si el contador de invencibilidad es mayor que 0
        if (invincibleCounter > 0)
        {
            //Le resto 1 a ese contador cada segundo
            invincibleCounter -= Time.deltaTime; //Time.deltaTime hace la condición impuesta en un segundo
            //Si el contador de invencibilidad ya ha llegado a 0
            if (invincibleCounter <= 0)
            {
                //Metemos en el sprite renderer un nuevo color al que le pasamos los valores RGB que ya tenía el jugador, y cambiamos el valor de la opacidad al máximo
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1f); //El valor de alpha está entre 0 y 1
            }
        }
    }

}
