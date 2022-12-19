using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{

    public Transform ball;
    private Vector3 Offset;
    public float SmoothSpeed;

    void Start()
    {
        Offset = transform.position - ball.position;    
    }

    
    void Update()
    {

        Vector3 newPos = Vector3.Lerp(transform.position, Offset + ball.position, SmoothSpeed);
        transform.position = newPos;

    }
}
