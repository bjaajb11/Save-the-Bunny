using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private EnemySpawner _enemySpawner;
    private bool _isGameOver;
    private int _score;
    public static GameManager Instance { get; private set; }

    public void SetGameOver()
    {
        _isGameOver = true;
        _enemySpawner.StopSpawning();
    }

    public void AddScore(int points)
    {
        if (_isGameOver) return;

        _score += points;
        print($"Current Score: {_score}");
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