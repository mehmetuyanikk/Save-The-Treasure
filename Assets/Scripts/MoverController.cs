using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverController : IPlayerController
{
    public float HorizontalAxis => Input.GetAxis("Horizontal") * Time.deltaTime;

    public float JumpAxis => Input.GetAxis("Jump");

    public void Horizontal(Transform _transform, float _horizontalSpeed, bool _isHorizontalActive)
    {
        switch (_isHorizontalActive)
        {
            case true:
                _transform.position += new Vector3(HorizontalAxis * _horizontalSpeed, 0);
                break;

            default:
                _isHorizontalActive = false;
                break;
        }
    }

    public void Jump(Rigidbody2D _rigidBody2D, float _jumpSpeed, bool _isJumpActive)
    {
        switch (_isJumpActive)
        {
            case true:
                _rigidBody2D.AddForce(Vector2.up * JumpAxis * _jumpSpeed);
                break;

            default:
                _isJumpActive = false;
                break;
        }
    }

    public void Flip(SpriteRenderer _spriteRenderer, bool _isFlipActive)
    {
        switch (_isFlipActive)
        {
            case true:
                if (HorizontalAxis > 0)
                {
                    _spriteRenderer.flipX = false;
                }
                else if (HorizontalAxis < 0)
                {
                    _spriteRenderer.flipX = true;
                }
                break;

            default:
                _isFlipActive = false;
                break;
        }
    }

}
