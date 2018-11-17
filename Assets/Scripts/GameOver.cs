using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
  
    public void SetScore(int score)
    {
        _scoreText.text = $"Score: {score}";
    }

  
}