using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int currentScore;

    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int scoreAmount)
    {
        currentScore += scoreAmount;
        //currentScore = currentScore + scoreAmount
    }
}
