using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int lifeCount = 5;
    
    public GameObject ballPrefab;
    
    public TextMeshProUGUI lifeCountText;

    public Transform spawnPosition;

    public int addedForce = 1;
    public int addedForceMax = 150;

    public void Awake()
    {
        instance = this;
    }
    
    private void Start()
    {
        SpawnBall();
        
        RefreshLifeCountText();
    }
    
    public void LoseLife()
    {
        Debug.Log(lifeCount - 1);

        lifeCount = lifeCount - 1;
        // lifeCount -= 1;
        // lifeCount--;

        addedForce = 1;

        if (lifeCount > -1)
        {
            RefreshLifeCountText();
            SpawnBall();
        }
        else
        {
            Debug.Log("Game Over");
        }
    }
    
    void SpawnBall()
    {
        Instantiate(ballPrefab,spawnPosition.localPosition,Quaternion.identity);
    }
    
    void RefreshLifeCountText()
    {
        lifeCountText.text = lifeCount.ToString();
    }

    public void AddedForce()
    {
        addedForce = addedForce + 1;

        if (addedForce > addedForceMax)
        {
            addedForce = addedForceMax;
        }
    }
}
