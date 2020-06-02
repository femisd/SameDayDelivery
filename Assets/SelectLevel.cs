using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    // Really dookie solution but this makes WAY easier to asign functionality to the onclick listener of buttons in unity
    // TODO: find a better solution (when I'm less baked...)
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Map1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Map2");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Map3");
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene("Map4");
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene("Map5");
    }

    public void LoadLevel6()
    {
        SceneManager.LoadScene("Map6");
    }

    public void LoadLevel7()
    {
        SceneManager.LoadScene("Map7");
    }

}
