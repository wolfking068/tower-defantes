﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KILLENMEYS : MonoBehaviour {
    public Rigidbody fire;
    public float throwpower;
    public float radius;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        kill();
	}
    void kill()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider hit in hitColliders)
        {
            if (hit.tag == "Enemy")
            {
                Rigidbody fire2 = Instantiate(fire,transform.position,transform.rotation) as Rigidbody;
                fire2.velocity = transform.position * throwpower;
            }



        }
    }
}
