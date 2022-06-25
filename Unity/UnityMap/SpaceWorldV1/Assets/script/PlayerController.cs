using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    protected Rigidbody rb;
    public float moveSpeed;
    public float rotateSpeed;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(Vector3.forward * moveSpeed);
        if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(Vector3.back * moveSpeed);
        if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(Vector3.left * moveSpeed);
        if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Vector3.right * moveSpeed);

        //float moveZ = 0f;
        //float moveX = 0f;

        //if (Input.GetKey(KeyCode.UpArrow)) moveZ += 1;
        //if (Input.GetKey(KeyCode.DownArrow)) moveZ -= 1;
        //if (Input.GetKey(KeyCode.LeftArrow)) moveX -= 1;
        //if (Input.GetKey(KeyCode.RightArrow)) moveX += 1;

        //transform.Translate(new Vector3(moveX, 0f, moveZ) * (moveSpeed * 0.1f));

        //float m1 = 0f;
        //float m2 = 0f;

        ////오른쪽 회전
        //if (Input.GetKey(KeyCode.D)) m1 += 1;
        ////왼쪽 회전
        //if (Input.GetKey(KeyCode.A)) m1 -= 1;
        ////아래로 회전
        //if (Input.GetKey(KeyCode.S)) m2 += 1;
        ////위로 회전
        //if (Input.GetKey(KeyCode.W)) m2 -= 1;

        //transform.Rotate(new Vector3(m2, m1, 0) * (rotateSpeed * 0.1f));

        //오른쪽 회전
        if (Input.GetKey(KeyCode.D)) transform.Rotate(Vector3.up * rotateSpeed);
        //왼쪽 회전
        if (Input.GetKey(KeyCode.A)) transform.Rotate(Vector3.down * rotateSpeed);
        //아래로 회전
        if (Input.GetKey(KeyCode.S)) transform.Rotate(Vector3.right * rotateSpeed);
        //위로 회전
        if (Input.GetKey(KeyCode.W)) transform.Rotate(Vector3.left * rotateSpeed);
    }
}
