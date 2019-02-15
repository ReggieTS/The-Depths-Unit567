using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttck : MonoBehaviour {

    private float TimeBetweenatk;
    public float StartTimeBetweenatk;

    public Transform atkPos;
    public float atkRange;
    public LayerMask theEnemy;
    public LayerMask SmallEnemy;
    public int dmg;
	
	// Update is called once per frame
	void Update ()
    {
		if (TimeBetweenatk <= 0)
        {
            if (Input.GetButton("Fire1"))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(atkPos.position, atkRange, theEnemy);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<SharkEnemy>().TakeDmg(dmg);


                }

               



            }
            TimeBetweenatk = StartTimeBetweenatk;
        }
        else
        {
            TimeBetweenatk -= Time.deltaTime;
        }
	}

   private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(atkPos.position, atkRange);
    }
}
