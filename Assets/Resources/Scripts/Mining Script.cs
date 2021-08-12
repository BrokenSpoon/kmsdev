using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningScript : MonoBehaviour
{
    public Vector3 clickPosition;

    // Start is called before the first frame update
    void Start()
    {    
    
    }

    // Update is called once per frame
    void Update()
    {
        Plane plane = new Plane(Vector3.up, 0);

        float distance;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out distance))
        {
            clickPosition = ray.GetPoint(distance);
        }
    }
}
