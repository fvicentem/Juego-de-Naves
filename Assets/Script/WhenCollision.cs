using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenCollision : MonoBehaviour
{
    
    //cuando la bala llegue al collider del límite se destruirá, así no consumirá memoria y recursos del PC y Móvil
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
