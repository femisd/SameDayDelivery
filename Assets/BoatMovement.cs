using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoatMovement : MonoBehaviour
{

    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;

    Vector3 nextPos;

    static float xPos = -15;
    Boolean checkRIght = true;

    Vector3 pos;

    public float speedUpDown = 3;
    public float distanceUpDown = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
        speedUpDown = 4;
        distanceUpDown = 0.4f;

    }

    // Update is called once per frame
    void Update()
    {

        /**
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }
        **/

        // transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        //  _newPosition = transform.position;
        //_newPosition.x += Mathf.Sin(Time.time) * Time.deltaTime;
        //transform.position = _newPosition;
       // Debug.Log(transform.position.x);

        if (pos2.position.x > transform.position.x)
        {
            checkRIght = false;

            Debug.Log("false yes");
        }

        if (pos1.position.x<transform.position.x)
        {
            checkRIght = true;
            Debug.Log("true yes");
        }

        if (checkRIght)
        {
            pos -= transform.right * Time.deltaTime * 1;

        }
        else
        {
            pos += transform.right * Time.deltaTime * 1;

        }

        Vector3 mov = new Vector3(pos.x, Mathf.Sin(speedUpDown * Time.time) * distanceUpDown, transform.position.z);
        
        transform.position = mov;

    }
}
