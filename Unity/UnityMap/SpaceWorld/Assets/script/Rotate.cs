using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float speed;

    void Start() {
        
    }

    void Update() {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
