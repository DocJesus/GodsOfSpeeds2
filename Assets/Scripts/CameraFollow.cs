using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float timeOffset;
    public float rotationSpeed;

    private Vector3 velocity;
    private float timeCount = 0.0f;


    private void FixedUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velocity, timeOffset);
        //transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, Time.time * rotationSpeed); //rotSpeed = 10
        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, rotationSpeed);
        timeCount = timeCount + Time.deltaTime;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
