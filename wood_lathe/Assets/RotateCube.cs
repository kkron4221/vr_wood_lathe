using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private bool isRotating = false;
    private float rotationSpeed = 50f;
    
    public void OnButtonPressed()
    {
        isRotating = true;
    }
    
    public void OnButtonReleased()
    {
        isRotating = false;
    }

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
