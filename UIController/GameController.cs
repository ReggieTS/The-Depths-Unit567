using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

   // private float roundTimer;
   // private bool gameActive;
   // public Text timeText;
    public static int score;
    public Text scoreText;

    void Start ()
    {
        //roundTimer = 180;
        // gameActive = true;
        score = 0;
    }
	
	
	void Update ()
    {
       // Roundtimer();
        Addscore();
	}

   /* public void Roundtimer()
    {
        if (gameActive)
        {
            roundTimer -= Time.deltaTime;
            timeText.text = "Time:" + Mathf.Round(roundTimer).ToString();

            if (roundTimer <= 0f)
            {
                EndRound();
            }
        }

    }*/

    public void Addscore()
    {
        
        scoreText.text = "Score:" + score.ToString();
    }




    /*public void EndRound()
    {
        gameActive = false;

        SceneManager.LoadScene("GameOver");
    }*/
}


