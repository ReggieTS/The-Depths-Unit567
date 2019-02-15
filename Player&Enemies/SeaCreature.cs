using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaCreature : MonoBehaviour {

    public float speed;
    public GameObject Player;


    private Transform target;

    public int seaCreatureHP = 60;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        print(seaCreatureHP);
    }


    void Update()
    {

    }


    void FixedUpdate()
    {
        if (GetComponent<Agro>().agro)

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (target.position.x > transform.position.x)
        {

            transform.localScale = new Vector2(-3, 3);
        }
        else if (target.position.x < transform.position.x)
        {

            transform.localScale = new Vector2(3, 3);
        }

        if (seaCreatureHP <= 0)
        {
            Destroy(gameObject);
        }

    }



    public void TakeDmg(int dmg)
    {
        seaCreatureHP -= dmg;
        Debug.Log("dmg Taken !");
    }




}

