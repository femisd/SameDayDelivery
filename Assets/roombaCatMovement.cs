using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roombaCatMovement : MonoBehaviour
{

    public float speed;
    public float followDistance;
    public Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < followDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
