using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Rotation : MonoBehaviour
{
    private Transform objectTransform;
    private int rotateAmount = 30;

    void Start()
    {
        objectTransform = GetComponent<Transform>();
    }

    public void RotateLeft()
    {
        objectTransform.Rotate(Vector3.up, rotateAmount);
    }

    public void RotateRight()
    {
        objectTransform.Rotate(Vector3.up, -rotateAmount);
    }
}
