using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavedScore : MonoBehaviour {

    public Text scoreText;

    // Update is called once per frame
    void Update ()
    {
        Addscore();
    }

    public void Addscore()
    {

        scoreText.text = "Score:" + GameController.score.ToString();
    }
}
