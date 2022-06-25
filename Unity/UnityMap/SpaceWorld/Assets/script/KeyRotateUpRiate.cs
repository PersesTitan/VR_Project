using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotateUpRiate : MonoBehaviour {
    public GameObject keyObject;
    public float speed;

    private void Update() {
        OrbitAround();
    }
 
    void OrbitAround() {
        transform.RotateAround(keyObject.transform.position, Vector3.right, speed * Time.deltaTime);
        transform.RotateAround(keyObject.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
