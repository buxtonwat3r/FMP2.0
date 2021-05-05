using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LevelComplete : MonoBehaviour
{
    [SerializeField] Transform spawnpoint;
    public int levelCompleteScene;
    public int RequiredCoins;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            if (ScoreManager.GetScore() >= RequiredCoins)
            {
                NextLevel();
            }

        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex)+1);
    }
}