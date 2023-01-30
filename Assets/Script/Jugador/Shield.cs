using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    //public bool escudo;
    public float duration = 3f;

    private void OnEnable()
    {
        StartCoroutine(disableShield());
        Debug.Log("Escudo activado");
    }

    IEnumerator disableShield()
    {
        yield return new WaitForSeconds(duration);

        gameObject.SetActive(false);

    }
}
