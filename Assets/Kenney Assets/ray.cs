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
                heath.losemoney(10);
               
             }
          }
        if(heath.money <= 0)
        {
            return;
        }

        }

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
