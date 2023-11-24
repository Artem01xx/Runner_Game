using UnityEngine;


public class Damage : MonoBehaviour
{
    Health PlayerHealth;
    [SerializeField] private AudioSource _damageSound;
    void Start()
    {
        PlayerHealth = FindObjectOfType<Health>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerHealth.PlayerHealth--;
            _damageSound.Play();
        }
    }
}
