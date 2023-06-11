using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{

    Vector3 mousePositionOffset;

    float planeY = 0;
    Transform draggingObject;
    Ray ray;

    Plane plane;

    private void Start()
    {
        draggingObject = transform;
        plane =new Plane(Vector3.up, Vector3.up * planeY); // ground plane

    }

    private void OnMouseDrag()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float distance; // the distance from the ray origin to the ray intersection of the plane
        if (plane.Raycast(ray, out distance))
        {
            transform.position = ray.GetPoint(distance); // distance along the ray
            transform.position = new Vector3(transform.position.x, transform.position.y+0.66f, transform.position.z);
        }
    }

    private void OnMouseUp()
    {
            transform.position = new Vector3(Mathf.Round(transform.position.x), transform.position.y, Mathf.Round(transform.position.z));

    }
}
