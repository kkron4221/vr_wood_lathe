using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAndMovement : MonoBehaviour
{
    public float speed = 10f;
    public float moveSpeed = 1f;
    public float rotateSpeed = 100f;
    
    public Vector3 axis = Vector3.up;    

    void Update()
    {   
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 rotateAxis = verticalInput > 0 ? Vector3.right : Vector3.left;
        
        float rotateDirection = verticalInput > 0 ? 1 : -1;
        
	transform.Rotate(rotateAxis, rotateDirection * rotateSpeed * Time.deltaTime);
	transform.Translate(Vector3.up * verticalInput * moveSpeed * Time.deltaTime);
    }
}
