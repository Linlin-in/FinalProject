using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    
    #region Singleton
    private static ScoreManager _instance;

    public static ScoreManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<ScoreManager>();
            }
            
            return _instance;
        }
    }
    #endregion
    
    
    public TextMeshProUGUI text;

    private int score = 0;

    private void Start()
    {
        IncScore(0);
    }

    public void IncScore(int add)
    {
        score += add;
        text.text = "Score :" + score;
    }

}
