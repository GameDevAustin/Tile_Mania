using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boar4_destroyer : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(GameObject.FindWithTag("boar_4"));
            Destroy(this.gameObject);
        }
    }
}
