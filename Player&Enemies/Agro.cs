using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agro : MonoBehaviour {

    public bool agro;
    public GameObject Player;

    public Transform pullPos;
    public float PullCheckRadius;

    void Update()
    {

        if (Physics2D.OverlapCircle(pullPos.position, PullCheckRadius, LayerMask.GetMask("Player")))
        {
            agro = true;
        }
        else
        {
            agro = false;
        }

    }



         private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(pullPos.position, PullCheckRadius);
    }


}
    

   


