using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Text _scoreText;

    private void Start()
    {
        _scoreText.text = $"Score: {GameManager.Instance.Score}";
    }
}