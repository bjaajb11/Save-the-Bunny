using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private EnemySpawner _enemySpawner;
    private bool _isGameOver;
    public static GameManager Instance { get; private set; }

    public void SetGameOver()
    {
        _isGameOver = true;
        _enemySpawner.StopSpawning();
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
}