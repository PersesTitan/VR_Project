using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour {
    
    public float speed;

    void Start() {
        
    }

    void Update() {

        // int count = Random.Range(10000, 1000000);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        // transform.Translate(Vector3.back * speed * Time.deltaTime);
        

    }
}
