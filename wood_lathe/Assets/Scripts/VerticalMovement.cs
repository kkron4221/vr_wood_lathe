using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float height = 1f;
    public float speed = 1f;
    private Vector3 initialPosition;
    
    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        float newY = initialPosition.y + Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
