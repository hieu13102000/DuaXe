using System;
using System.Threading;
using System.Diagnostics.Contracts;
using System.Runtime.Serialization;
using System.Globalization;
using System.Collections.Specialized;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject sphere;
    private Vector3 vector3;
    public GameObject carCam;
    // Start is called before the first frame update
    void Start()
    {
        //vector3 = new Vector3(0, 0.5f, -5.09f);
        vector3 =  transform.position - sphere.transform.position;
        carCam = GameObject.Find("carCam");
    }

    // Update is called once per frame
    void FixedUpdate()
    {    // kết nối với tranform của component của vật thể Camera
        transform.position = Vector3.Lerp(this.transform.position, carCam.transform.position, 50 * Time.deltaTime);
        this.transform.LookAt(sphere.transform);
        
    }

}
