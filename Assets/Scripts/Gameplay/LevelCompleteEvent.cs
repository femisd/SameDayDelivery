using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteEvent : MonoBehaviour
{
public void LoadNextLevel()
    {
        NextScene();
    }

    // Use for testing to restart the level
    void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
