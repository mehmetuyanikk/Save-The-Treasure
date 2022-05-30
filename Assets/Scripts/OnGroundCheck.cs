using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGroundCheck : MonoBehaviour
{
    [SerializeField] Transform[] _translates;
    [SerializeField] bool _isOnGround = false;
    [SerializeField] float _maxDistance;
    [SerializeField] LayerMask _layerMask;

    public bool IsOnGround => _isOnGround;

    private void Update()
    {
        foreach (Transform footTransform in _translates)
        {
            CheckFootOnGround(footTransform);
            if (_isOnGround) break;
            {

            }
        }
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
