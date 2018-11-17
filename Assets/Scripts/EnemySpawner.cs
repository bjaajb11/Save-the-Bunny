using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _horizontalLimits;
    [SerializeField] private float _spawnRate;

    private void SpawnSpike()
    {
        var position = transform.position;
        position.x = Random.Range(-_horizontalLimits, _horizontalLimits);
        Instantiate(_enemyPrefab, position, Quaternion.identity);
    }

    private void Start()
    {
        StartSpawning();
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnSpike", 1f, _spawnRate);
    }
    private void Stoppawning()
    {
        CancelInvoke("SpawnSpike");
    }
}