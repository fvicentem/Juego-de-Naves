using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Hacemos un Singleton del script. Es decir, hacemos que solamente pueda haber un script de este tipo. Podremos acceder con esta instance a este script desde cualquier lugar
    public static AudioManager instance;

    //Array donde guardar los efectos de sonido
    //public AudioSource[] soundEffects;

    //Variables donde guardar la m�sica de fondo y la de cuando acabamos el nivel, y mientras estemos en el boss final
    public AudioSource bgm, levelEndMusic, vfx;
    

    public List<AudioClip> sounds;
    //M�todo que se ejecuta antes de empezar el juego
    private void Awake()
    {
        //Significa que la instance del UIController va a ser este propio script
        instance = this;
    }

    public void PlaySound(int _Index)
    {
        vfx.PlayOneShot(sounds[_Index]);
        vfx.pitch = Random.Range(.9f, 1.1f);
    }

    //M�todo para reproducir los efectos de sonido, le debemos pasar la posici�n del sonido dentro del array, del que queramos reproducir
    public void PlaySFX(int soundToPlay)
    {
        //Desactivamos el sonido si ya se estuviera reproduciendo
        //soundEffects[soundToPlay].Stop();

        ////Esto var�a el pitch de cada sonido reproducido, de manera aleatoria, entre ese rango de valores
        

        ////Reproducimos el efecto de sonido que queremos
        //soundEffects[soundToPlay].Play();
    }
}
