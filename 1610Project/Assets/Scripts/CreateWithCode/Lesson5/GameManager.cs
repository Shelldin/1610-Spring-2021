﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    public TextMeshProUGUI scoreText,
            gameOverText;
    private int score;

    private float spawnRate = 1f;
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
    }

    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
            
        }
        
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score:" + score; 
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }
}