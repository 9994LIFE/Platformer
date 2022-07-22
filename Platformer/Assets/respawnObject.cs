using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<playermovement>() != null)
        {
            collision.gameObject.GetComponent<playermovement>().respawn();
        }
    }


}
