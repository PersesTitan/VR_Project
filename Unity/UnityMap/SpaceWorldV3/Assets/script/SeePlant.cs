using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeePlant : MonoBehaviour {

    // public GameObject obj;
    public Transform target;
    public float speed;

    void Start() {

    }

    void Update() {
        // Vector3 spotPos = target.transform.position;
        // Vector3 dif = transform.position - target.transform.position;
        // Quaternion angle = Quaternion.LookRotation(dif, target.up);
        // this.rotation = Quaternion.Lerp(target.localRotation, angle, Time.deltaTime);
        // transform.Translate(Vector3.forward * speed);

        float angle = 0;

        Vector3 relative = transform.InverseTransformPoint(target.position);
        angle = Mathf.Atan2(relative.x, relative.y) * Mathf.Rad2Deg;
        transform.Rotate(0, 0, -angle);

        //Quaternion rot = transform.localRotation;
        //rot.y -= 90;
        //transform.localRotation = rot;


        //transform.LookA
        //t(target);
        transform.Translate(speed * Time.deltaTime * Vector3.left);

    }
}
