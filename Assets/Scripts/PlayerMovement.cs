using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    Vector2 moveInput;
    private Rigidbody2D _playerRigidBody;
    [SerializeField] private float _speed = 5f;
    private Animator _animator;
    [SerializeField] private float _jumpSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        FlipSprite();
    }

    private void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }

    void OnJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerRigidBody.velocity += new Vector2(0f, _jumpSpeed);
           
            _animator.SetBool("isSpaceBarActive", true);

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            _animator.SetBool("isSpaceBarActive", false);
        }
         
    }


    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * _speed, _playerRigidBody.velocity.y);
        _playerRigidBody.velocity = playerVelocity;
        bool _playerRun = Mathf.Abs(_playerRigidBody.velocity.x) > Mathf.Epsilon; //Use Mathf.Epsilon in place of zero

        _animator.SetBool("isRunning", _playerRun);

    }

    // flip character direction based on input
    private void FlipSprite()
    {
        bool _playerRun = Mathf.Abs(_playerRigidBody.velocity.x) > Mathf.Epsilon; //Use Mathf.Epsilon in place of zero

        if (_playerRun)
        {
            transform.localScale = new Vector2(Mathf.Sign(_playerRigidBody.velocity.x), 1f);
        }
    }
}
