using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;
using Vector3 = UnityEngine.Vector3;

public class CameraFollow : MonoBehaviour
{
    private Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;


    private void Update()
    {
        target = GameObject.FindGameObjectsWithTag("Player")[0].transform;
    }
    private void LateUpdate()
    {

        Vector3 targetPosition = target.position + offset;
        Vector3 smoothedPosition = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, targetPosition.y, smoothSpeed * Time.deltaTime), transform.position.z);
        transform.position = smoothedPosition;

    }
}