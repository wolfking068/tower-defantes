using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour {
    public new Camera camera;
    public GameObject tower;

    public LayerMask RaycastMask;
    public float money;
    public health heath;
    // Use this for initialization
    void Start () {
        money = 10;
        heath = heath.GetComponent<health>();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (heath.money> 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                
                Ray();
                
                // @harley: Looks like you're losing money with no regard as to
                //          whether or not you actually built a tower after
                //          raycasting.
                //
                //          Consider adding a return value from your Ray()
                //          function that returns whether or not a tower was
                //          built, which should let you wrap the following code
                //          in a branch that only runs after building something.
                heath.losemoney(10);
                heath.money3();
               
             }
          }

        // @harley: This code seems redundant.
        if(heath.money <= 0)
        {
            return;
        }

        }

    // @harley: I would name this something more descriptive, like...
    //          - TryBuildTower
    //          - AttemptBuildTower
    //
    //          Or even better, you could separate the process of building a
    //          tower from the process of searching for a location to build on.
    void Ray()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, RaycastMask))
        {
            var spawntower = Instantiate(tower);
            spawntower.transform.position = hit.point;
        }
    }
}
