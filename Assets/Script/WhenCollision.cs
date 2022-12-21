using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenCollision : MonoBehaviour
{
    
    //cuando la bala llegue al collider del l�mite se destruir�, as� no consumir� memoria y recursos del PC y M�vil
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
