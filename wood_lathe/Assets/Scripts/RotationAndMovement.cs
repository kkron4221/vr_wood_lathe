using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAndMovement : MonoBehaviour
{
    public float speed = 10f;
    public float moveSpeed = 1f;
    public Vector3 axis = Vector3.up;    

    void Update()
    {
        transform.Rotate(axis, -speed * Time.deltaTime);
        
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 newPosition = transform.position + Vector3.up * verticalInput * moveSpeed * Time.deltaTime;
        transform.position = newPosition;
    }
}
