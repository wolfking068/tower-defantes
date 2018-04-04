using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NewBehaviourScript : MonoBehaviour {
    public GameObject kill;
    NavMeshAgent agent;
    public EnemySpawner enemy2;
    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        agent.destination = kill.transform.position;
	}
    void OnTriggerEnter(Collider hit)
    {
        var think = hit.GetComponent<IDamageable>();
        if (think != null && hit.tag == "PlayerHealth")
        {

            think.takeDamage(1);
            die();
           
        }
    }
    public void die()
    {
        enemy2.currentanmontofenemys -= 1;
        Destroy(gameObject);
    }
}
