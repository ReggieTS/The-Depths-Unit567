using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUp : MonoBehaviour {
    public AudioClip Coin;

    public AudioSource CoinSource;

    void Start()
    {
        CoinSource = GetComponent<AudioSource>();
        CoinSource.clip = Coin;
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {

            GameController.score += 10;
            print("points");
            Destroy(this.gameObject, 0.2f);
            CoinSource.Play();
        }
    }
}
