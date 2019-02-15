using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {


    private float roundTimer;
    private bool gameActive;
    public Text timeText;

    // Use this for initialization
    void Start ()
    {
        roundTimer = 120;
        gameActive = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Roundtimer();
    }

    public void Roundtimer()
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

    }

    public void EndRound()
    {
        gameActive = false;

        SceneManager.LoadScene("GameOver");
    }
}
