using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public GameObject boss;
    public RawImage healthBarCanvas;
    public BallSpeed ballSpeed;

    [SerializeField] private BossHealthUI bossHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bossHealth.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            TakeDamage(- ballSpeed.ballDamage);
        }
    }

    public void TakeDamage(float damage)
    {
        health += damage;
        health = Mathf.Clamp(health, 0, maxHealth);

        bossHealth.SetHealth(health);

        if (health <= 0)
        {
            Destroy(boss);
            healthBarCanvas.gameObject.SetActive(false);
        }
    }
}
