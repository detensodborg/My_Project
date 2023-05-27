using UnityEngine;

public class ObjectRotatorWithCursor : MonoBehaviour
{
    public float rotationSpeed = -50f;

    private bool isRotating = false;
    private Vector3 previousMousePosition;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
            previousMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            Vector3 currentMousePosition = Input.mousePosition;
            float deltaX = currentMousePosition.x - previousMousePosition.x;

            RotateObject(deltaX);

            previousMousePosition = currentMousePosition;
        }
    }

    private void RotateObject(float deltaX)
    {
        float rotationAmount = -deltaX * rotationSpeed; 

        transform.Rotate(Vector3.up, rotationAmount, Space.World);
    }
}
