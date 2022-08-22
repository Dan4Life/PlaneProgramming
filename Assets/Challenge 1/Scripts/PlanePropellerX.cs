using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    // speed at which propeller rotates
    private float speed = 1000.0f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
}
