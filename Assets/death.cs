using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour {
    public Rigidbody fire;
    public float throwpower;
    public float radius;
    public GameObject ENEMY;
    public float timer;
    // Use this for initialization
    void Start()
    {
        // @harley: Avoid hard-coding values for things like your timer in Start(),
        //          especially if they're public and visible to the inspector.
        
        //          It can be especially confusing if you set a value in the
        //          inspector that ultimately gets overridden in script.
        timer = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        kill();

    }
    void kill()
    {

        if (timer <= 0)
        {
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider hit in hitColliders)
            {
                if (hit.tag == "Enemy")
                {


                    Rigidbody fire2 = Instantiate(fire, transform.position, transform.rotation) as Rigidbody;
                    fire2.velocity = (hit.transform.position - transform.position) * throwpower;
                    timer = 5;

                }



            }
        }
    }
}
