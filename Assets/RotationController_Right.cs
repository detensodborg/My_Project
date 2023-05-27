using UnityEngine;

public class RotationController_Right : MonoBehaviour
{
    public ObjectRotator objectRotator;
    public float rotationAmount = -30f;
    public Vector3 rotationAxis = Vector3.up;

    public void RotateObjectOnClick()
    {
        objectRotator.RotateObject(rotationAmount, rotationAxis);
    }
}