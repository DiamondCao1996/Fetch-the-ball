using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour

{
    public GameObject dog;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); 
        if (dog.transform.position.x<18)
        {
            dog.transform.Translate(new Vector3(3,0,0));
        }
        
    }
}
