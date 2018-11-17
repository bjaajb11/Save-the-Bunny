using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    
    [SerializeField]private float _moveSpeed = 3f;
    [SerializeField] private float _xConstraint = 5;
	private void Awake()
	{
	    _rigidbody = GetComponent<Rigidbody2D>();
	}
	
	private void FixedUpdate()
	{
	    Move();
	}

    private void Move()
    {
        var xInput = Input.GetAxis("Horizontal");
        var position = transform.position;
        position.x += xInput * _moveSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -_xConstraint, _xConstraint);
        _rigidbody.MovePosition(position);
    }
}
