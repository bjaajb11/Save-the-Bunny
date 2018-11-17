using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private GameObject _dust;
	private void FixedUpdate () {
	transform.Rotate(0, 0, _rotationSpeed);	
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.SetGameOver();
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Ground"))
        {
            Instantiate(_dust, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
