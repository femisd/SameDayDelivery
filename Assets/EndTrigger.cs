using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EndTrigger : MonoBehaviour
{
    public GameObject completeLevelUI;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CompleteLevel();
    }



    void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
