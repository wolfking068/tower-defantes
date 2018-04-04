using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killlgun : MonoBehaviour {
    public GameObject ENEMY;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider hit)
    {
        if(hit.tag == "Enemy")
        {
            hit.GetComponent<NewBehaviourScript>().die();
            Destroy(gameObject);
        }
    }
}
