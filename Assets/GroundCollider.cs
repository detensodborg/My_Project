using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    private Vector3 lastMousePosition;
    private bool isDragging;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
            isDragging = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            Vector3 deltaMouse = Input.mousePosition - lastMousePosition;
            transform.position += new Vector3(deltaMouse.x, 0f, deltaMouse.y) * 0.01f;
            lastMousePosition = Input.mousePosition;

            UpdateCollider();
        }
    }

    private void UpdateCollider()
    {
        Collider groundCollider = GetComponent<Collider>();
        groundCollider.enabled = false; // Disable the collider temporarily
        groundCollider.enabled = true; // Enable the collider to recalculate bounds
    }
}
