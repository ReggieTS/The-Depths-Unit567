using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {


    public Collider2D Col;


    
    void Awake()
    {
        Col = GetComponent<Collider2D>();
        Col.isTrigger = true;

    }

    
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("GameOver");

    }

    
}
