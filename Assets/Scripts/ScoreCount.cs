using UnityEngine.UI;
using UnityEngine;


public class ScoreCount : MonoBehaviour
{
    private Text _scoreText;
    public Text BestResult;
    public Text Result;
    [SerializeField] private Transform _playerTransform;
    public static ScoreCount Instanse;
    private int _currentScore;
    private int _bestScore;

    private void Awake()
    {
        Instanse = this;
        if (PlayerPrefs.HasKey("SaveScore"))
        {
            _bestScore = PlayerPrefs.GetInt("SaveScore");
        }
    }

    void Start()
    {
        _scoreText = GetComponent<Text>();
    }

    void Update()
    {
        _scoreText.text = _playerTransform.position.z.ToString("0");

        BestResult.text = _bestScore.ToString();
        Result.text = _scoreText.text;
        HightScore();
    }

    private void HightScore()
    {
        _currentScore = int.Parse(_scoreText.text);

        if (_currentScore > _bestScore)
        {
            _bestScore = _currentScore;
        }

        PlayerPrefs.SetInt("SaveScore", _bestScore);
    }
}
