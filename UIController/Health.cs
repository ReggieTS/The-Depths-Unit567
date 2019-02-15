using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
   public Image healthBar;
    
   // int maxHealth = 100;

    // Use this for initialization
    void Start ()
    {
        healthBar = GetComponent<Image>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        healthBar.fillAmount =  GetComponent<PlayerController>().PlayerHealth;
	}
}
