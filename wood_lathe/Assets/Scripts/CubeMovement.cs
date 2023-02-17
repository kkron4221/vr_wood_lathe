using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    private Transform cubeTransform;

    void Start()
    {
        cubeTransform = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            StartCoroutine(MoveCubeUp());
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine(MoveCubeDown());
        }
    }

    IEnumerator MoveCubeUp()
    {
        while (Input.GetKey(KeyCode.UpArrow))
        {
            cubeTransform.RotateAround(cubeTransform.position, Vector3.up, -10f * Time.deltaTime);
            cubeTransform.position += new Vector3(0f, 1f * Time.deltaTime, 0f);
            yield return null;
        }
    }

    IEnumerator MoveCubeDown()
    {
        while (Input.GetKey(KeyCode.DownArrow))
        {
            cubeTransform.RotateAround(cubeTransform.position, Vector3.up, 10f * Time.deltaTime);
            cubeTransform.position -= new Vector3(0f, 1f * Time.deltaTime, 0f);
            yield return null;
        }
    }
}
