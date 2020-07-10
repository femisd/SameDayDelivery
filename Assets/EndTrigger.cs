using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class EndTrigger : MonoBehaviour
{
    public GameObject completeLevelUICanvas;
    public GameObject package;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CompleteLevel();
        }
        Rigidbody2D packageBody = collision.gameObject.GetComponent<Rigidbody2D>();
        packageBody.velocity = Vector2.zero;
        packageBody.freezeRotation = true;
    }



    void CompleteLevel()
    {
        completeLevelUICanvas.SetActive(true);
    }
}
