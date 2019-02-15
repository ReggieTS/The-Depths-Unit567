using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOPress : MonoBehaviour {
    

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);

        Time.timeScale = 1f;
    }

}


