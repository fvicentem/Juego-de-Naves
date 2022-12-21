using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerDavid : MonoBehaviour
{

    public GameObject[] Enemigo; //saldrá que hay que poner un objeto para ese codigo, en este caso pondremos el prefab de "Enemigo"
    public float maxSpawnRateInSeconds = 2f; //el tiempo que tardará en aparecer un enemigo, aquí como he puesto 5f tendrá que ser cada 5 segundos


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


    //Función para el spawn de nuestro enemigo
    void SpawnEnemy() 
    {
        //esto será para que el enemigo aparezca en la posición baja izquierda de la pantalla
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));


        //esto será para que el enemigo aparezca en la posición alta derecha de la pantalla
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        //Con esto aparecerá el enemigo, en este caso aparecerá el objeto al que he llamado "enemigo"
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
