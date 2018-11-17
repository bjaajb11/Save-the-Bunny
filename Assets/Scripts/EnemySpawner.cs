using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _horizontalLimits;
    [SerializeField] private float _spawnRate;

    internal void StartSpawning()
    {
        InvokeRepeating(nameof(SpawnSpike), 1f, _spawnRate);
    }

    internal void StopSpawning()
    {
        CancelInvoke(nameof(SpawnSpike));
    }

    private void SpawnSpike()
    {
        var position = transform.position;
        position.x = Random.Range(-_horizontalLimits, _horizontalLimits);
        Instantiate(_enemyPrefab, position, Quaternion.identity);
    }
}