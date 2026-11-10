using UnityEngine;
using UnityEngine.UI;

public class BallSpeed : MonoBehaviour
{
    public GameManager gameManager;
    public ParticleSystem fireball1;
    public ParticleSystem fireball2;
    public ParticleSystem fireball3;
    public int ballDamage = 10;
    
    void Start()
    {
        gameManager = GameManager.instance;
    }
    
    void Update()
    {
        if (gameManager.addedForce == 40)
        {
            fireball1.Play();
            gameManager.addedForce = gameManager.addedForce + 5;
            ballDamage = ballDamage + 5;
        }

        if (gameManager.addedForce == 70)
        {
            fireball2.Play();
            gameManager.addedForce = gameManager.addedForce + 10;
            ballDamage = ballDamage + 10;
        }

        if (gameManager.addedForce == 120)
        {
            fireball3.Play();
            gameManager.addedForce = gameManager.addedForce + 15;
            ballDamage = ballDamage + 10;
        }

    }
}
