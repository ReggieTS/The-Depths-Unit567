using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Highscore : MonoBehaviour {

    public int HighscoreValue;
    public Text HighScore;

    // Use this for initialization
    void Start()
    {

        HighScore.text = "Highscore:" + PlayerPrefs.GetInt("Highscore:", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {

        HighscoreValue = GameController.score;

        if (PlayerPrefs.GetInt("Highscore:") < HighscoreValue)
        {
            PlayerPrefs.SetInt("Highscore:", HighscoreValue);
            HighScore.text = "Highscore:" + HighscoreValue.ToString();
        }

        

    }


   
}
