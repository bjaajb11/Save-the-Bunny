using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private float _rotationSpeed;

	private void FixedUpdate () {
	transform.Rotate(0, 0, _rotationSpeed);	
	}
}
