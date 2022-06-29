using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotate : MonoBehaviour {

    public GameObject keyObject;
    public float speed;

    private void Update() {
        OrbitAround();
    }
 
    void OrbitAround() {
        transform.RotateAround(keyObject.transform.position, Vector3.down, speed * Time.deltaTime);
    }
}
