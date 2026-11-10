using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameManager gameManager;
    
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        
        gameManager.LoseLife();
    }
}
