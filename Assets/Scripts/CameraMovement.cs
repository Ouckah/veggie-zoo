using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 origin;
    private Vector3 difference;
    private Vector3 resetCamera;

    private bool isDragging = false;

    private void Start()
    {
        resetCamera = Camera.main.transform.position;
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            difference = (Camera.main.ScreenToWorldPoint(Input.mousePosition)) - Camera.main.transform.position;
            if (!isDragging)
            {
                isDragging = true;
                origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
        else
        {
            isDragging = false;
        }


        if (isDragging)
        {
           Camera.main.transform.position = origin - difference; 
        }

        if (Input.GetMouseButton(1))
        {
            Camera.main.transform.position = resetCamera;
        }
    }
}
