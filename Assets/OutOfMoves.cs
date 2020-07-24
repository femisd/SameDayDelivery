using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfMoves : MonoBehaviour
{

    public GameObject gameOverMenuCanvas;
    public static bool isGameOver;

    void Update()
    {
        if (DragAndShoot.currentNumberOfMoves < 0)
        {
            enableGameOverState();
        }
    }

    public void enableGameOverState()
    {
        isGameOver = true;
        gameOverMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void extraLifeState()
    {
        isGameOver = false;
        gameOverMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        DragAndShoot.resetCurrentNumberOfMoves();
    }


    public void replayLevel()
    {
        isGameOver = false;
        gameOverMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public static void resetGameOverState()
    {
        Time.timeScale = 1f;
        isGameOver = false;
    }





}
