using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour {
    public new Camera camera;
    public GameObject tower;

    public LayerMask RaycastMask;

    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray();
        }
	}
    void Ray()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity ,RaycastMask))
        {
            var spawntower = Instantiate(tower);
            spawntower.transform.position = hit.point;
        }
    }
}
