using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position=target.position-offset;

        transform.LookAt(target);

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedH * Input.GetAxis("Mouse Y");

        yaw = Mathf.Clamp(yaw, -120f, 120f);
        //the rotation range
        pitch = Mathf.Clamp(pitch, -60f, 90f);
        //the rotation range

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
