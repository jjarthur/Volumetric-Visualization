using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour
{
    float rotationSpeed = 150;

    private void OnMouseDrag()
    {
        float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Mathf.Deg2Rad;
        float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotationX);
        transform.Rotate(Vector3.right, -rotationY);
    }

}