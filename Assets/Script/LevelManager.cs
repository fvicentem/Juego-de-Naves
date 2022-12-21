using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Librería para poder hacer cambios entre niveles
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    //Hacemos un Singleton del script. Es decir, hacemos que solamente pueda haber un script de este tipo. Podremos acceder con esta instance a este script desde cualquier lugar
    public static LevelManager instance;

    //Variable para llevar un conteo de gemas que hemos cogido
    public int gemCollected;


    //Variable donde guardar el tiempo de completar nivel
    public float timeInLevel;

    //Método que se ejecuta antes de empezar el juego
    private void Awake()
    {
        //Significa que la instance del UIController va a ser este propio script
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos el tiempo que llevamos en el nivel
        timeInLevel = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Vamos aumentado el tiempo que llevamos jugando el nivel
        timeInLevel += Time.deltaTime;
    }

    //Método para hacerle respawn al jugador
   

  
   
  
}
