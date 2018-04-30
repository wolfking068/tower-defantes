using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour, IDamageable, money
{
    public int Health;
    public int money;
    // Use this for initialization
    void Start () {
        Health = 100;
        money = 50;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
   public void takeDamage(int damageTaken)
    {
        Health -= damageTaken;
    }
    public void losemoney(int speand)
    {
        money -= speand;
    }
    public void ganemoney(int add)
    {
        money += add;
    }
}
