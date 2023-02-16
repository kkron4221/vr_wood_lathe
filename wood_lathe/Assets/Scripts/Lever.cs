using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public float moveDistance = 1.0f;
    
    private bool isMoved = false;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isMoved)
        {
            transform.position -= new Vector3(0f, moveDistance, 0f);
            isMoved = true;
        }
    }            
}
