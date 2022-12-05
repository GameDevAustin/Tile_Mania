using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{

    public GameObject[] hearts;
    public int life;

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        if (life < 1) 
        {
            Destroy(hearts[0].gameObject);
        } 
        else if (life < 2) 
        {
            Destroy(hearts[1].gameObject);
        } 
        else if (life < 3) 
        {
            Destroy(hearts[2].gameObject);
        }
        
    }

    public void TakeDamage (int damage)
    {
        life -= damage;
    }
}
