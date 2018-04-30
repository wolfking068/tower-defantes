using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killlgun : MonoBehaviour {
    public GameObject ENEMY;
    public float timer;
    public health heath;
    // Use this for initialization
    void Start () {
        timer = 10;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if(timer<= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider hit)
    {
        var think = hit.GetComponent<IDamageable>();
        if (think != null && hit.tag == "Enemy")
        {
            think.takeDamage(2);
            Destroy(gameObject);
        }
    }
}
