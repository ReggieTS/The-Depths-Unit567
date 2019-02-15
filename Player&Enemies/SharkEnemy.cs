using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkEnemy : MonoBehaviour {

    public float speed;
    public GameObject Player;
    private float dazed;
    public float startDazed;
    public int points;
    

    private Transform target;
    
    public int sharkHealth = 100;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        print(sharkHealth);
    }


    void Update()
    {
      if (dazed <= 0)
        {
            speed = 4;
        }

        else
        {
            speed = 0;
            dazed -= Time.deltaTime;
        }
    }


    void FixedUpdate()
    {
        //if (Agro.agro == true)
        if (GetComponent<Agro>().agro)
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (target.position.x > transform.position.x)
        {

            transform.localScale = new Vector2(-4, 4);
        }
        else if (target.position.x < transform.position.x)
        {

            transform.localScale = new Vector2(4, 4);
        }

        if(sharkHealth <= 0)
        {
            GameController.score += points;
            Destroy(gameObject);
        }

    }

        
        
        public void TakeDmg(int dmg)
    {
        dazed = startDazed;
        sharkHealth -= dmg;
        Debug.Log("dmg Taken !");
    }
    

   
   
}

