using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class DragAndShoot : MonoBehaviour
{

    public float power = 10f;
    public Rigidbody2D rb;

    public Vector2 minPower;
    public Vector2 maxPower;


    public int moves = 5;
    public static int maxNumberOfMoves;
    public static int currentNumberOfMoves;

    public GameObject movesText;

    TrajectoryLine tl;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;

    private void Start()
    {
        maxNumberOfMoves = moves; // quick workaround to make the maximum moves avalabile form the inspector for difficulty calibration.
        cam = Camera.main;
        tl = GetComponent<TrajectoryLine>();
        currentNumberOfMoves = maxNumberOfMoves;
        OutOfMoves.resetGameOverState();
    }

    private void Update()
    {
        movesText.GetComponent<UnityEngine.UI.Text>().text = "Moves Remaining: " + currentNumberOfMoves.ToString();

        if (!PauseMenu.isPaused && !OutOfMoves.isGameOver)
        {
            // Mobile controls
            if (Input.touchCount > 0)
            {

                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    startPoint = cam.ScreenToWorldPoint(Input.GetTouch(0).position);
                    startPoint.z = 15;
                }

                if (Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    Vector3 currentPoint = cam.ScreenToWorldPoint(Input.GetTouch(0).position);
                    startPoint.z = 15;
                    tl.RenderLine(startPoint, currentPoint);
                }

                // If touch goes Up
                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    endPoint = cam.ScreenToWorldPoint(Input.GetTouch(0).position);
                    endPoint.z = 15;

                    force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
                    rb.AddForce(force * power, ForceMode2D.Impulse);

                    tl.EndLine();
                    currentNumberOfMoves--;
                }
            }


            // PC controls

            if (Input.GetMouseButtonDown(0))
            {
                startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                startPoint.z = 15;
            }

            if (Input.GetMouseButton(0))
            {
                Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                startPoint.z = 15;
                tl.RenderLine(startPoint, currentPoint);
            }

            if (Input.GetMouseButtonUp(0))
            {
                endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                endPoint.z = 15;

                force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
                rb.AddForce(force * power, ForceMode2D.Impulse);

                tl.EndLine();
                currentNumberOfMoves--;

            }
        }



    }

    public static void resetCurrentNumberOfMoves()
    {
        currentNumberOfMoves = maxNumberOfMoves +1;
    }




}
