using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    private Transform objectTransform;

    void Start()
    {
        objectTransform = GetComponent<Transform>();
    }

    public void RotateObject(float rotationAmount, Vector3 rotationAxis)
    {
        objectTransform.Rotate(rotationAxis, rotationAmount);
    }
}