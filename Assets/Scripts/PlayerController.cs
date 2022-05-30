using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    MoverController _moverController;

    [SerializeField] Transform _playerTransform;
    [SerializeField] SpriteRenderer _playerSpriteRenderer;
    [SerializeField] Rigidbody2D _playerRigidBody2D;
    [SerializeField] float _playerSpeed, _jumpSpeed;
    [SerializeField] bool _isHorizontalActive, _isJumpActive, _isFlipActive;

    [SerializeField] Animator _animator;

    [SerializeField] Transform[] _translates;
    [SerializeField] bool _isOnGround = false;
    [SerializeField] float _maxDistance;
    [SerializeField] LayerMask _layerMask;

    public bool IsOnGround => _isOnGround;

    //bool _isSpaceControl;

    private void Awake()
    {
        _moverController = new MoverController();
    }

    private void FixedUpdate()
    {
        Walk();
        Jump();
        Flip();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //_isSpaceControl = true;
            _isOnGround = true;
        }

        foreach (Transform footTransform in _translates)
        {
            CheckFootOnGround(footTransform);
            if (_isOnGround) break;
            {

            }
        }
    }

    void Walk()
    {
        _moverController.Horizontal(_playerTransform, _playerSpeed, _isHorizontalActive);
        _animator.SetFloat("Walk", Mathf.Abs(Input.GetAxis("Horizontal")));
    }

    void Jump()
    {
        if (_isOnGround)
        {
            _moverController.Jump(_playerRigidBody2D, _jumpSpeed, _isJumpActive);
            //_animator.SetBool("Jump", _isOnGround);
        }
        _isOnGround = false;
    }

    void Flip()
    {
        _moverController.Flip(_playerSpriteRenderer, _isFlipActive);
    }

    void CheckFootOnGround(Transform footTransform)
    {
        RaycastHit2D hit = Physics2D.Raycast(footTransform.position, footTransform.forward, _maxDistance, _layerMask);
        Debug.DrawRay(footTransform.position, footTransform.forward * _maxDistance, Color.blue);

        if (hit.collider != null)
        {
            _isOnGround = true;
        }
        else
        {
            _isOnGround = false;
        }
    }

}
