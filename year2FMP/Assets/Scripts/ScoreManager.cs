using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    static int score;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
            ChangeScore(0);
        }
    }
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "X" + score.ToString();
    }
    public static int GetScore()
    {
        return score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void SavePlayer()
    //{
    //    SaveSystem.SavePlayer(this);
    //}

    //public void LoadGame()
    //{
    //    PlayerData data = SaveSystem.LoadPlayer();

    //    score = data.score;
    //}
}
