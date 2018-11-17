using UnityEngine;

public class DestroyOnStart : MonoBehaviour
{
    [SerializeField] private float _lifetime;

    private void Start()
    {
        Destroy(gameObject, _lifetime);
    }
}