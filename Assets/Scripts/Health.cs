using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int PlayerHealth;
    public int NumbersOfHealth;

    public Image[] hearts;
    public Sprite Heart;
    public Sprite EmptyHeart;
    public Canvas canvas;

    [SerializeField] private AudioSource _backgroundMusic;


    private void Start()
    {
        _backgroundMusic.Play();
    }

    private void Update()
    {
        if(PlayerHealth <= 0)
        {
            canvas.gameObject.SetActive(true);
            _backgroundMusic.Pause();
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }


        for (int i = 0; i < hearts.Length; i++) 
        { 
            if(i <  NumbersOfHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < PlayerHealth)
            {
                hearts[i].sprite = Heart;
            }
            else
            {
                hearts[i].sprite = EmptyHeart;
            }
        }
    }

}
