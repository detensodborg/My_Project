using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public Transform groundTransform;
    public float movementSpeed = 1f;
    public float idleTimeThreshold = 5f; // 5 seconds

    private Rigidbody rb;
    private Vector3 targetPosition;
    private bool isMoving;
    private float idleTimer;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        isMoving = true;
        idleTimer = 0f;
        SetRandomTargetPosition();
    }

    private void Update()
    {
        if (isMoving)
        {
            MoveSphere();

            idleTimer += Time.deltaTime;
            if (idleTimer >= idleTimeThreshold)
            {
                SetRandomTargetPosition();
                idleTimer = 0f;
            }
        }
        else
        {
            CheckForInput();
        }
    }

    private void CheckForInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == groundTransform.gameObject)
                {
                    targetPosition = hit.point;
                    isMoving = true;
                }
            }
        }
    }

    private void MoveSphere()
    {
        // Calculate the direction to the target position
        Vector3 direction = (targetPosition - transform.position).normalized;

        // Apply movement using Rigidbody
        rb.velocity = direction * movementSpeed;

        // Check if the target position is reached
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            SetRandomTargetPosition();
        }
    }

    private void SetRandomTargetPosition()
    {
        Vector3 groundCenter = groundTransform.position;
        Vector3 groundSize = groundTransform.localScale;

        float xMin = groundCenter.x - groundSize.x / 2f;
        float xMax = groundCenter.x + groundSize.x / 2f;
        float zMin = groundCenter.z - groundSize.z / 2f;
        float zMax = groundCenter.z + groundSize.z / 2f;

        float randomX = Random.Range(xMin, xMax);
        float randomZ = Random.Range(zMin, zMax);

        targetPosition = new Vector3(randomX, transform.position.y, randomZ);
    }
}
