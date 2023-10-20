using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groud : MonoBehaviour
    
{
    // Start is called before the first frame update
    Renderer renderer;
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
        renderer.material.color = Color.red;
    }

    // Update is called once per frame
  
}
