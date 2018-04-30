using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class health : MonoBehaviour, IDamageable, money
{
    public int Health;
    public int money;
    public Text money2;
    // Use this for initialization
    void Start () {
        Health = 100;
        money = 50;
        money3();
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
    public void money3()
    {
        money2.text = "money left:" + money.ToString();
    }
}
