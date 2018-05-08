using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    //Spawning Variables
    public GameObject Enemey;
    public float range;
    public float time;
    private float timer;
    public int max;
    public int currentanmontofenemys;
    public List<GameObject> listOfEnemies;
    public health stuff;
    // Use this for initialization
    void Start ()
    {
        listOfEnemies = new List<GameObject>();
	}



   public void SpawnFunction()
    {
        //Spawn The enemy just like the pick up
        GameObject spawnedEnemey = Instantiate(Enemey);
        spawnedEnemey.transform.position = transform.position;
        listOfEnemies.Add(spawnedEnemey);
        
        // @harley: If you need to access a component on a newly spawned GameObject
        //          more than once, then you should cache it in a variable to avoid
        //          calling GetComponent on it more than once for the same component.
        spawnedEnemey.GetComponent<NewBehaviourScript>().enemy2 = this;
        currentanmontofenemys += 1;
        spawnedEnemey.GetComponent<NewBehaviourScript>().hea1th = stuff;
    }

	
	// Update is called once per frame
	void Update () {
      
        timer -= Time.deltaTime;
        if (timer <= 0 && currentanmontofenemys < max)
        {
            SpawnFunction();
            timer = time;
        }
    }
}
