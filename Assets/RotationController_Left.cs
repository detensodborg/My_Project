using UnityEngine;

public class RotationController_Left : MonoBehaviour
{
    public ObjectRotator objectRotator;
    public float rotationAmount = 30;
    public Vector3 rotationAxis = Vector3.up;

    public void RotateObjectOnClick()
    {
        objectRotator.RotateObject(rotationAmount, rotationAxis);
    }
}