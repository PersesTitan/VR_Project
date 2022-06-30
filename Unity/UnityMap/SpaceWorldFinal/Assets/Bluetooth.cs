using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;
using System;
using System.Globalization;

public class Bluetooth : MonoBehaviour {

    protected Rigidbody rb;
    public float moveSpeed;
    // public float rotateSpeed;
    // public string port; //포트 넣기
    private SerialPort sp = new SerialPort();

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        sp.PortName = "COM5";
        sp.BaudRate = 19200;
        sp.DataBits = 8;
        sp.Parity = Parity.None;
        sp.StopBits = StopBits.One;
        sp.Open();
    }

    // Update is called once per frame
    void Update() {

        string[] lines = sp.ReadLine().Split(' ');
        // string[] lines = Input.inputString.Split(' ');
        int x_joy = int.Parse(lines[0]);
        int y_joy = int.Parse(lines[1]);
        int z_joy = int.Parse(lines[2]);
        // float x = float.Parse(lines[0]);
        // float y = float.Parse(lines[1]);
        // float z = float.Parse(lines[2]);

        // int x = Int32.Parse(lines[0]);
        // int y = Int32.Parse(lines[1]);
        // int z = Int32.Parse(lines[2]);

        transform.Translate(x_joy*moveSpeed,0,y_joy*moveSpeed);

        // transform.rotation = Quaternion.Euler(new Vector3(x*10,y*10,0));

        // transform.Rotate(Vector3.up * rotateSpeed * x);
        // transform.Rotate(Vector3.right * rotateSpeed * y);

        Debug.Log(x_joy);
        Debug.Log(y_joy);
        Debug.Log(z_joy);

    }
}
