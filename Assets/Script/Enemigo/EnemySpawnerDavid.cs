using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerDavid : MonoBehaviour
{

    public GameObject[] Enemigo; //saldr� que hay que poner un objeto para ese codigo, en este caso pondremos el prefab de "Enemigo"
    public float maxSpawnRateInSeconds = 2f; //el tiempo que tardar� en aparecer un enemigo, aqu� como he puesto 5f tendr� que ser cada 5 segundos


    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", maxSpawnRateInSeconds);

        InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Funci�n para el spawn de nuestro enemigo
    void SpawnEnemy() 
    {
        //esto ser� para que el enemigo aparezca en la posici�n baja izquierda de la pantalla
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));


        //esto ser� para que el enemigo aparezca en la posici�n alta derecha de la pantalla
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        //Con esto aparecer� el enemigo, en este caso aparecer� el objeto al que he llamado "enemigo"
        GameObject anEnemy = (GameObject)Instantiate(Enemigo[Random.Range(0, Enemigo.Length)]);
        anEnemy.transform.position = new Vector2(0, max.y);

        ScheduleNextEnemySpawn();
    }

    void ScheduleNextEnemySpawn() 
    {
        float spawnInSeconds;

        if (maxSpawnRateInSeconds > 1f)
        {
            //escoger un numero entre el 1 y el maxSpawnRateInSeconds
            spawnInSeconds = Random.Range(1f, maxSpawnRateInSeconds);
        }
        else spawnInSeconds = 1f;

        Invoke("SpawnEnemy", spawnInSeconds);
    
    }

    //funcion para aumentar la dificultad del juego
    void IncreaseSpawnRate() 
    {
        if (maxSpawnRateInSeconds > 1f) maxSpawnRateInSeconds--;

        if (maxSpawnRateInSeconds == 1f) CancelInvoke("IncreaseSpawnRate");
    }
}
