using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Librería para usar la interfaz de Unity

public class UIController : MonoBehaviour
{
    //Hacemos un Singleton del script. Es decir, hacemos que solamente pueda haber un script de este tipo. Podremos acceder con esta instance a este script desde cualquier lugar
    public static UIController instance;

    //Variables para cambiar las imágenes
    public Image heart1, heart2, heart3;
    //Variables de las imágenes que queremos cambiar
    public Sprite heartFull, heartEmpty, heartHalf;
    //Variable del texto que queremos cambiar
    public Text gemText;

    


    //Variable para el texto de haber terminado el nivel
    public GameObject levelCompleteText;

    //Método que se ejecuta antes de empezar el juego
    private void Awake()
    {
        //Significa que la instance del UIController va a ser este propio script
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

   

    // Update is called once per frame
    void Update()
    {
       
    }

    //Método donde actualizar el estado de los corazones
    public void UpdateHealthDisplay()
    {
        //En base a la vida actual que tengamos
        switch (HealthPlayer.instance.currentHealth)
        {
            //Si la vida actual es 6
            case 6:
                heart1.sprite = heartFull;
                heart2.sprite = heartFull;
                heart3.sprite = heartFull;

                break;

            //Si la vida actual es 5
            case 5:
                heart1.sprite = heartFull;
                heart2.sprite = heartFull;
                heart3.sprite = heartHalf;

                break;

            //Si la vida actual es 4
            case 4:
                heart1.sprite = heartFull;
                heart2.sprite = heartFull;
                heart3.sprite = heartEmpty;

                break;

            //Si la vida actual es 3
            case 3:
                heart1.sprite = heartFull;
                heart2.sprite = heartHalf;
                heart3.sprite = heartEmpty;

                break;

            //Si la vida actual es 2
            case 2:
                heart1.sprite = heartFull;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;

                break;

            //Si la vida actual es 1
            case 1:
                heart1.sprite = heartHalf;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;

                break;

            //Si la vida actual es 0
            case 0:
                heart1.sprite = heartEmpty;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;

                break;

            //Si la vida actual es cualquier otro valor
            default:
                heart1.sprite = heartEmpty;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;

                break;
        }
    }

    //Método para actualizar la cuenta de las gemas recogidas
   

    //Método para hacer fundido a negro
    
}
