using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2_destroyer : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(GameObject.FindWithTag("Enemy_2"));
            Destroy(this.gameObject);
        }
    }
}
