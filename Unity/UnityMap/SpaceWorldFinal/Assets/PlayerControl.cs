using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;
using System;
using System.Globalization;

public class PlayerControl : MonoBehaviour {

    protected Rigidbody rb;
    public float moveSpeed;
    public float rotateSpeed;
    // public string port; //포트 넣기
    private SerialPort sp = new SerialPort();
    private double x = 0;
    private double y = 0;
    private double z = 0;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        sp.PortName = "COM5";
        sp.BaudRate = 19200;
        sp.DataBits = 8;
        sp.Parity = Parity.None;
        sp.StopBits = StopBits.One;
        sp.Open();

        string[] lines = sp.ReadLine().Split(' ');
        x = double.Parse(lines[3]);
        y = double.Parse(lines[4]);
        z = double.Parse(lines[5]);
    }

    // Update is called once per frame
    void Update() {


        string[] lines = sp.ReadLine().Split(' ');
        // string[] lines = Input.inputString.Split(' ');
        int x_joy = int.Parse(lines[0]);
        int y_joy = int.Parse(lines[1]);
        int z_joy = int.Parse(lines[2]);
        x += double.Parse(lines[3]);
        y += double.Parse(lines[4]);
        z += double.Parse(lines[5]);


        // float z = float.Parse(lines[2]);

        // int x = Int32.Parse(lines[0]);
        // int y = Int32.Parse(lines[1]);
        // int z = Int32.Parse(lines[2]);

        transform.Translate(y_joy*moveSpeed,0,x_joy*moveSpeed);

        // transform.rotation = Quaternion.Euler(new Vector3(x*10,y*10,0));

        // transform.Rotate(Vector3.up * rotateSpeed * x);
        // transform.Rotate(Vector3.right * rotateSpeed * y);

        transform.rotation = Quaternion.Euler((float)-x,(float)-z,(float)-y);
        
        if (z_joy == 0)
        {
            string[] li = sp.ReadLine().Split(' ');
            x = double.Parse(li[3]);
            y = double.Parse(li[4]);
            z = double.Parse(li[5]);
        }
    }
}
