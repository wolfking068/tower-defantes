using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NewBehaviourScript : MonoBehaviour,IDamageable {
    public GameObject kill;
    NavMeshAgent agent;
    private int heath;
    public EnemySpawner enemy2;
    public health hea1th;
    
    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        heath = 5;
        hea1th = hea1th.GetComponent<health>();

    }
	
	// Update is called once per frame
	void Update () {
        agent.destination = kill.transform.position;
	}
    public void takeDamage(int damageTaken)
    {
        heath -= damageTaken;
        if(heath <= 0)
        {
            
            die();
        }
    }
    void OnTriggerEnter(Collider hit)
    {
        var think = hit.GetComponent<IDamageable>();
        if (think != null && hit.tag == "PlayerHealth")
        {

            think.takeDamage(1);
            enemy2.currentanmontofenemys -= 1;
            Destroy(gameObject);

        }
    }
    public void die()
    {

        hea1th.ganemoney(10);
        hea1th.money3();
        enemy2.currentanmontofenemys -= 1;
        Destroy(gameObject);
    }
}
