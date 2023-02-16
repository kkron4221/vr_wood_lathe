using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wood_clone : MonoBehaviour
{
    public GameObject prefab;
    
    private void OnMouseDown()
    {
        Vector3 originalPosition = transform.position;
        
        GameObject clone = Instantiate(prefab);
        
        Vector3 newPosition = originalPosition + Vector3.up * 0.1f;
        clone.transform.position = newPosition;
        
        clone.transform.SetParent(transform.parent);
    }
}
