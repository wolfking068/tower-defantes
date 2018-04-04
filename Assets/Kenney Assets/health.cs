using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour, IDamageable
{
    public int Health;
	// Use this for initialization
	void Start () {
        Health = 5;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
   public void takeDamage(int damageTaken)
    {
        Health -= damageTaken;
    }
}
