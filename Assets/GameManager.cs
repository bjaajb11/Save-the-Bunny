﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private EnemySpawner _enemySpawner;
    private bool _isGameOver;
    private int _score;
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameOver _gameOverPanel;
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private Transform _playerSpawnPoint;
    public static GameManager Instance { get; private set; }
    public int Score => _score;

    public void SetGameOver()
    {
        _isGameOver = true;        
        _gameOverPanel.gameObject.SetActive(true);
        _gameOverPanel.SetScore(_score);
        _enemySpawner.StopSpawning();
    }

    public void AddScore(int points)
    {
        if (_isGameOver) return;

        SetScore(_score + points);
    }

    private void SetScore(int score)
    {
        _score = score;
        print($"Current Score: {score}");
        _scoreText.text = score.ToString();
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        StartGame();
    }

    public void StartGame()
    {
        _isGameOver = false;
        Instantiate(_playerPrefab, _playerSpawnPoint.position, Quaternion.identity);
        SetScore(0);
        _gameOverPanel.gameObject.SetActive(false);
        _enemySpawner.StartSpawning();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }   

}