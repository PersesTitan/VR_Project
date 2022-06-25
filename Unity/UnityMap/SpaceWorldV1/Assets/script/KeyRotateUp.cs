using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotateUp : MonoBehaviour {
    public GameObject keyObject;
    public float speed;

    private void Update() {
        OrbitAround();
    }
 
    void OrbitAround() {
        transform.RotateAround(keyObject.transform.position, Vector3.right, speed * Time.deltaTime);
    }
}
