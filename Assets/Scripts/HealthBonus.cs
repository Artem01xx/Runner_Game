using UnityEngine;


public class HealthBonus : MonoBehaviour
{
    Health PlayerHealth;
    [SerializeField] private AudioSource _healthSound;
    void Start()
    {
        PlayerHealth = FindObjectOfType<Health>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && PlayerHealth.PlayerHealth < PlayerHealth.NumbersOfHealth)
        {
            _healthSound.Play();
            PlayerHealth.PlayerHealth++;
            Destroy(gameObject);
        }
    }
}
