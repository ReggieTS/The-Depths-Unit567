using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {


    public Collider2D Col;


    // Use this for initialization
    void Awake()
    {
        Col = GetComponent<Collider2D>();
        Col.isTrigger = true;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("Won");

    }


}
