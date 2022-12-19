using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public int BreakRing;
    public int Rscore;
    

    public Text scoreText;
    void Start()
    {

    }

    void Update()
    {

    }
    public void BreakRingScore(int BreakScore)
    {
        BreakRing += BreakScore;
        if (BreakRing >=4)
        {
           // Debug.Log("Deneme");
        }

    }
    public void GameScore(int ringScore)
    {
        score += ringScore;
        score = score * Ring.Combo;
        Rscore = score;
        scoreText.text = Rscore.ToString();
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
