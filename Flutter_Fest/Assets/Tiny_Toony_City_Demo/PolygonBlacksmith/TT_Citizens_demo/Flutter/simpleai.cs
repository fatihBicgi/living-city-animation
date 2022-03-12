using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleai : MonoBehaviour
{
    public float speed= 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed*Time.deltaTime);
    }
}
