using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;


    private void LateUpdate()
    {

        Vector3 targetPosition = target.position + offset;
        Vector3 smoothedPosition = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, targetPosition.y, smoothSpeed * Time.deltaTime), transform.position.z);
        transform.position = smoothedPosition;

    }
}