using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HeartSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text _gameOverText;
    public GameObject[] hearts;
    public int life;

    
     
    void Start()
    {
        
    }

    public void Update()
    {
       if (life < 1) 
        {
            Destroy(hearts[0].gameObject);
            Destroy(this.gameObject);
            
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
