using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    //private Player _player;
    [SerializeField] private Transform player;
    [SerializeField] private float _xOffset, _yOffset, _zOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        //_player = GameObject.Find("Player_Knight").GetComponent<PlayerMovement>(); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + _xOffset, player.position.y + _yOffset, _zOffset);
    }
}
