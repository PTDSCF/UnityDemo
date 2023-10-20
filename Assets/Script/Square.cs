using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isNEmpty = false;
    private Collider coll;
    private Rigidbody r;
    
    void Start()
    {
        coll = GetComponent<Collider>();
        r = GetComponent<Rigidbody>();
        r.sleepThreshold = 0.0f;
       
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void OnCollisionStay(Collision collision)
    {
        isNEmpty = true;
    }

}
