using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DogBack : MonoBehaviour
{
    public float backSpeed = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    [Obsolete("Obsolete")]
    private void OnTriggerEnter(Collider other)
    {
        float backDistance = backSpeed * Time.deltaTime;
        transform.Rotate(0, 180, 0);

    }
}
